using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
	public void Configure(EntityTypeBuilder<Role> builder)
	{
		builder.ToTable(Tables.Role);

		builder.HasKey(e => e.Id);

		builder.HasMany(e => e.Permissions)
			.WithMany()
			.UsingEntity<RolePermission>();

		builder.HasMany(x => x.Users)
			.WithMany(x => x.Roles);

		builder.HasData(Role.GetValues());
	}
}
