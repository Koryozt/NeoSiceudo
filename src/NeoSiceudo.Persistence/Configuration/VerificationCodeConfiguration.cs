using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class VerificationCodeConfiguration : IEntityTypeConfiguration<VerificationCode>
{
	public void Configure(EntityTypeBuilder<VerificationCode> builder)
	{
		builder.ToTable(Tables.VerificationCode);

		builder.HasKey(c => new { c.Id, c.Combination });

		builder.HasOne(c => c.User)
			.WithOne(c => c.VerificationCode)
			.HasForeignKey<VerificationCode>(c => c.UserId)
			.OnDelete(DeleteBehavior.Cascade);
	}
}
