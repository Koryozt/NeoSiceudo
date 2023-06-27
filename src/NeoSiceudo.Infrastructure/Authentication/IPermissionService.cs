﻿namespace NeoSiceudo.Infrastructure.Authentication;

public interface IPermissionService
{
	Task<HashSet<string>> GetPermissionsAsync(Guid userId);
}