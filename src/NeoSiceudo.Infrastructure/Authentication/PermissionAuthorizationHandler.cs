﻿using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace NeoSiceudo.Infrastructure.Authentication;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequeriment>
{
	private readonly IServiceScopeFactory _scopeFactory;

	public PermissionAuthorizationHandler(IServiceScopeFactory scopeFactory)
	{
		_scopeFactory = scopeFactory;
	}

	protected override async Task HandleRequirementAsync(
		AuthorizationHandlerContext context,
		PermissionRequeriment requirement)
	{
		string? memberId = context
		.User
		.Claims
		.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub)?.Value;

		if (!Guid.TryParse(memberId, out Guid memberGuid))
			return;

		using IServiceScope scope = _scopeFactory.CreateScope();

		IPermissionService permissionService = scope.ServiceProvider
			.GetRequiredService<IPermissionService>();

		HashSet<string> permissions = await permissionService
			.GetPermissionsAsync(memberGuid);

		if (permissions.Contains(requirement.Permission))
		{
			context.Succeed(requirement);
		}
	}
}