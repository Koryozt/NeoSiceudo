using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Entities;

public sealed class Course : AggregateRoot, IAuditableEntity
{
	private List<Information> _information = new();

	public Course(
		Guid id,
		Name name,
		Code code,
		User teacher) : base(id)
	{
		Name = name;
		Code = code;
		Teacher = teacher;
	}

	public Name Name { get; private set; }
	public Name SemesterName { get; private set; }
	public Code Code { get; private set; }

	public int Credits { get; private set; }
	public int Section { get; private set; }
	public double Grade { get; private set; }
	public IReadOnlyCollection<Information> Information => _information;
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }


	public Guid TeacherId { get; private set; }
	public User Teacher { get; private set; }
}
