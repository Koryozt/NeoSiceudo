using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Persistence.Constants;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Persistence.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
	public void Configure(EntityTypeBuilder<Student> builder)
	{
		builder.ToTable(Tables.Student);

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
			.WithOne(c => (Student)c.User)
			.HasForeignKey<VerificationCode>(c => c.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasMany(u => u.Careers)
			.WithMany(c => c.Students)
			.UsingEntity<StudentCareer>();

		builder.HasMany(u => u.Semesters)
			.WithOne(s => s.SemesterStudent)
			.HasForeignKey(s => s.SemesterStudentId)
			.OnDelete(DeleteBehavior.NoAction);

		builder.HasMany(u => u.Payments)
			.WithOne(p => p.PaymentStudent)
			.HasForeignKey(p => p.PaymentStudentId)
			.OnDelete(DeleteBehavior.NoAction);
	}
}
