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
		User student) : base(id)
	{
		Name = name;
		Year = year;
		Student = student;
	}

	public Name Name { get; private set; }
	public Year Year { get; private set; }
	public double AverageGrade => CoursesEnrolled.Sum(e => e.Grade);

	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public Guid StudentId { get; set; }
	public User Student { get; private set; }
	public ICollection<Course> CoursesEnrolled { get; set; }
}
