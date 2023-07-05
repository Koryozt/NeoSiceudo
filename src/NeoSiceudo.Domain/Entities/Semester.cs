using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Semester;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Entities;

public sealed class Semester : AggregateRoot, IAuditableEntity
{
	public Semester(
		Guid id,
		Name name,
		Year year,
		Student student) : base(id)
	{
		SemesterName = name;
		Year = year;
		SemesterStudent = student;
	}

	public double AverageSemesterGrade
	{
		get
		{
			if (CoursesEnrolled.Count is 0)
				return 0.0;

			return CoursesEnrolled.Sum(c => c.Grade) / CoursesEnrolled.Count;
		}
	}

	public Name SemesterName { get; private set; }
	public Year Year { get; private set; }

	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public Guid SemesterStudentId { get; set; }
	public Student SemesterStudent { get; private set; }
	public ICollection<Course> CoursesEnrolled { get; set; }
}
