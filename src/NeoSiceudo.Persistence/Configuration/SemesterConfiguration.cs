using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class SemesterConfiguration : IEntityTypeConfiguration<Semester>
{
	public void Configure(EntityTypeBuilder<Semester> builder)
	{
		builder.ToTable(Tables.Semester);

		builder.HasKey(s => s.Id);

		builder.HasOne(s => s.SemesterStudent)
			.WithMany(u => u.Semesters)
			.HasForeignKey(s => s.SemesterStudentId);

		builder.HasMany(s => s.CoursesEnrolled)
			.WithOne(c => c.Semester)
			.HasForeignKey(s => s.SemesterId);
	}
}
