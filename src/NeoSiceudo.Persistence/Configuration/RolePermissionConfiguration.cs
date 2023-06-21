using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Enumerators;

namespace NeoSiceudo.Persistence.Configuration;

public sealed class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
{
	public void Configure(EntityTypeBuilder<RolePermission> builder)
	{
		builder.HasKey(x => new { x.RoleId, x.PermissionId });

		builder.HasData(
			Create(Role.Registered, Permissions.ReadUser));
	}

	private static RolePermission Create(Role role, Permissions permission)
	{
		return new RolePermission
		{
			RoleId = role.Id,
			PermissionId = (int)permission
		};
	}
}