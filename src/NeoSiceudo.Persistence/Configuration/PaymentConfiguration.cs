using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
	public void Configure(EntityTypeBuilder<Payment> builder)
	{
		builder.ToTable(Tables.Payment);

		builder.HasKey(p => p.Id);

		builder.HasOne(p => p.PaymentStudent)
			.WithMany(u => u.Payments)
			.HasForeignKey(p => p.PaymentStudentId);
	}
}
