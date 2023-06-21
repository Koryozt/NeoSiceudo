using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class CareerConfiguration : IEntityTypeConfiguration<Career>
{
	public void Configure(EntityTypeBuilder<Career> builder)
	{
		builder.ToTable(Tables.Career);

		builder.HasKey(c => c.Id);

		builder.HasIndex(c => c.Name).IsUnique();

		builder.Property(c => c.Name)
			.HasConversion(x => x.Value, v => Name.Create(v).Value);

		builder.Property(c => c.BossName)
			.HasConversion(x => x.Value, v => Name.Create(v).Value);

		builder.Property(c => c.Key)
			.HasConversion(
				x => x.ToString(),
				v => (CareerKey)Enum.Parse(typeof(CareerKey), v));

		builder.HasMany(c => c.Students)
			.WithMany(u => u.Careers)
			.UsingEntity<UserCareer>();

	}
}
