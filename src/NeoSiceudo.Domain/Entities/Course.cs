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
		int credits,
		int coupons,
		int section,
		Teacher teacher) : base(id)
	{
		CourseName = name;
		Code = code;
		Credits = credits;
		Coupons = coupons;
		Section = section;
		Teacher = teacher;
	}

	public Name CourseName { get; private set; }
	public Code Code { get; private set; }
	public int Credits { get; private set; }
	public int Coupons { get; private set; }
	public int Section { get; private set; }
	public double Grade { get; private set; }
	public bool IsApproved => Grade >= 5;
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }
	public IReadOnlyCollection<Information> Information => _information;

	public Guid TeacherId { get; private set; }
	public Guid SemesterId { get; private set; }
	public Semester Semester { get; private set; }
	public Teacher Teacher { get; private set; }
}
