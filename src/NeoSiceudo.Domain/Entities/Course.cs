using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Entities;

// THIS ENTITY IS BAD IMPLEMENTED, BECAUSE THERES NO METHOD TO GET:
// THE AMOUNT OF PEOPLE IN A SINGLE COURSE (NEEDED FOR ENROLLMENTS TO SEE HOW MANY COUPONS ARE LEFT).
// THE GRADE OF EACH ONE

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
		User teacher) : base(id)
	{
		Name = name;
		Code = code;
		Credits = credits;
		Coupons = coupons;
		Section = section;
		Teacher = teacher;
		Enrolled = new HashSet<Enrolled>();
	}

	public Name Name { get; private set; }
	public Code Code { get; private set; }

	public int Credits { get; private set; }
	public int Coupons { get; private set; }
	public int Section { get; private set; }
	public User Teacher { get; private set; }
	public Guid TeacherId { get; private set; }
	public Semester Semester { get; private set; }
	public Guid SemesterId { get; private set; }
	public IReadOnlyCollection<Information> Information => _information;
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }
	public ICollection<Enrolled> Enrolled { get; set; }
}
