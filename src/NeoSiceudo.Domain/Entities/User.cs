using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Entities;

public sealed class User : AggregateRoot, IAuditableEntity
{
	public User(
		Guid id,
		Name firstname,
		Name lastname,
		Email email,
		Password password,
		IdentityCard identityCard,
		string? photo,
		double averageGrade,
		DateTime birthday) : base(id)
	{
		Firstname = firstname;
		Lastname = lastname;
		Email = email;
		Password = password;
		IdentityCard = identityCard;
		Photo = photo;
		AverageGrade = averageGrade;
		Birthday = birthday;
	}

	public Name Firstname { get; private set; }
	public Name Lastname { get; private set; }
	public Email Email { get; private set; }
	public Password Password { get; private set; }
	public IdentityCard	IdentityCard { get; private set; }
	public string? Photo { get; private set; }
	public string Salt { get; init; }
	public double AverageGrade { get; private set; }
	public DateTime Birthday { get; private set; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public Guid VerificationCodeId { get; private set; }
	public VerificationCode VerificationCode { get; private set; }
	public ICollection<Career> Careers { get; set; }
	public ICollection<Semester> Semesters { get; set; }
	public ICollection<Course> CoursesTeached { get; set; }
	public ICollection<Payment> Payments { get; set; }

}
