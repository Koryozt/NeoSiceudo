using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class CourseConfiguration : IEntityTypeConfiguration<Course>
{
	public void Configure(EntityTypeBuilder<Course> builder)
	{
		builder.ToTable(Tables.Course);

		builder.HasKey(c => c.Id);

		builder.HasAlternateKey(c => c.Section);

		builder.Property(c => c.Name)
			.HasConversion(
				x => x.Value,
				v => Name.Create(v).Value);

		builder.Property(c => c.Code)
			.HasConversion(
				x => x.Value,
				v => Code.Create(v).Value);

		builder.HasOne(c => c.Teacher)
			.WithMany(t => t.CoursesTaught)
			.HasForeignKey(c => c.TeacherId)
			.OnDelete(DeleteBehavior.NoAction);

		builder.HasMany(c => c.Enrolled)
			.WithOne(e => e.Course)
			.HasForeignKey(c => c.CourseId)
			.OnDelete(DeleteBehavior.NoAction);

	}
}
