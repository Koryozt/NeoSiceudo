using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

public sealed class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
	public void Configure(EntityTypeBuilder<Permission> builder)
	{
		builder.ToTable(Tables.Permission);

		builder.HasKey(e => e.Id);

		IEnumerable<Permission> permissions = Enum.GetValues<Permissions>()
			.Select(e => new Permission()
			{
				Id = (int)e,
				Name = e.ToString()
			});

		builder.HasData(permissions);
	}
}