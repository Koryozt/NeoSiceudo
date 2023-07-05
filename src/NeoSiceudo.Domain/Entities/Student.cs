using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Entities;

public sealed class Student : User
{
	public Student(
		Guid id, 
		Name firstname, 
		Name lastname, 
		Email email, 
		Password password, 
		IdentityCard identityCard, 
		string? photo, 
		DateTime birthday,
		bool isFrozen) : base(
			id, firstname, lastname, email, password, identityCard, photo, birthday)
	{
		IsFrozen = isFrozen;
	}

	public bool IsFrozen { get; private set; }
	public double AverageGrade
	{
		get
		{
			if (Semesters.Count is 0)
				return 0.0;

			return Semesters.Sum(s => s.AverageSemesterGrade) / Semesters.Count;
		}
	}

	public ICollection<Career> Careers { get; set; }
	public ICollection<Semester> Semesters { get; set; }
	public ICollection<Payment> Payments { get; set; }
}
