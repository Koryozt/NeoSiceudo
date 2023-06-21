using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Domain.Entities;

public sealed class Enrolled : AggregateRoot, IAuditableEntity
{
	public Enrolled(
		Course course,
		User student)
	{
		Course = course;
		Student = student;
		Grade = 0.0;
	}

	public Guid StudentId { get; private set; }
	public Guid CourseId { get; private set; }
	public Course Course { get; private set; }
	public User Student { get; private set; }
	public double Grade { get; private set; }
	public bool IsApproved => Grade >= 5;

	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }
}
