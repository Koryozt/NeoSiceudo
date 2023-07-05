using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
	public void Configure(EntityTypeBuilder<Teacher> builder)
	{
		builder.ToTable(Tables.Teacher);

		builder.HasKey(u =>
			new { u.Id, u.IdentityCard });

		builder.HasIndex(u => u.Email).IsUnique();

		builder.Property(u => u.Firstname)
			.HasConversion(x => x.Value, v => Name.Create(v).Value);

		builder.Property(u => u.Lastname)
			.HasConversion(x => x.Value, v => Name.Create(v).Value);

		builder.Property(u => u.Email)
			.HasConversion(x => x.Value, v => Email.Create(v).Value);

		builder.Property(u => u.Password)
			.HasConversion(x => x.Value, v => Password.Create(v).Value);

		builder.Property(u => u.IdentityCard)
			.HasConversion(x => x.Value, v => IdentityCard.Create(v).Value);

		builder.HasOne(u => u.VerificationCode)
			.WithOne(c => (Teacher)c.User)
			.HasForeignKey<VerificationCode>(c => c.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(u => u.CoursesTaught)
			.WithOne(c => c.Teacher)
			.HasForeignKey(c => c.TeacherId)
			.OnDelete(DeleteBehavior.NoAction);
	}
}
