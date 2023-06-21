using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class EnrolledConfiguration : IEntityTypeConfiguration<Enrolled>
{
	public void Configure(EntityTypeBuilder<Enrolled> builder)
	{
		builder.ToTable(Tables.Enrolled);

		builder.HasKey(t => t.Id);

		builder.HasOne(e => e.Course)
			.WithMany(c => c.Enrolled)
			.HasForeignKey(e => e.CourseId)
			.OnDelete(DeleteBehavior.NoAction);

	}
}
