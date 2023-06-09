﻿using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Persistence;

namespace NeoSiceudo.Infrastructure.Authentication;

public class PermissionService : IPermissionService
{
	private readonly ApplicationDbContext _context;

	public PermissionService(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<HashSet<string>> GetPermissionsAsync(Guid userId)
	{
		ICollection<Role>[] roles = await _context.Set<User>()
			.Include(x => x.Roles)
			.ThenInclude(x => x.Permissions)
			.Where(x => x.Id == userId)
			.Select(x => x.Roles)
			.ToArrayAsync();

		return roles
			.SelectMany(x => x)
			.SelectMany(x => x.Permissions)
			.Select(x => x.Name)
			.ToHashSet<string>();
	}
}