using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Payment;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Entities;

public sealed class Payment : AggregateRoot, IAuditableEntity
{
	public Payment(
		Guid id,
		Name subject,
		Reference reference,
		DateTime date,
		bool madeOnline,
		Student student) : base(id)
	{
		Concept = subject;
		Reference = reference;
		PerformedOn = date;
		MadeOnline = madeOnline;
		PaymentStudent = student;
	}

	public Name Concept { get; private set; }
	public Reference Reference { get; init; }
	public bool MadeOnline { get; private set; }
	public DateTime PerformedOn { get; init; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public Guid PaymentStudentId { get; private set; }
	public Student PaymentStudent { get; private set; }
}
