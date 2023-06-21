using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;
using NeoSiceudo.Persistence.Constants;

namespace NeoSiceudo.Persistence.Configuration;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.ToTable(Tables.User);

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
			.WithOne(c => c.User)
			.HasForeignKey<VerificationCode>(c => c.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(u => u.Careers)
			.WithMany(c => c.Students)
			.UsingEntity<UserCareer>();

		builder.HasMany(u => u.Semesters)
			.WithOne(s => s.Student)
			.HasForeignKey(s => s.StudentId)
			.OnDelete(DeleteBehavior.NoAction);

		builder.HasMany(u => u.CoursesTaught)
			.WithOne(c => c.Teacher)
			.HasForeignKey(c => c.TeacherId)
			.OnDelete(DeleteBehavior.NoAction);

		builder.HasMany(u => u.Payments)
			.WithOne(p => p.User)
			.HasForeignKey(p => p.Id)
			.OnDelete(DeleteBehavior.NoAction);
	}
}
