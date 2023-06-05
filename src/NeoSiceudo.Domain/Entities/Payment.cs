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
		User user) : base(id)
	{
		Subject = subject;
		Reference = reference;
		Date = date;
		MadeOnline = madeOnline;
		User = user;
	}

	public Name Subject { get; private set; }
	public Reference Reference { get; init; }
	public DateTime Date { get; init; }
	public bool MadeOnline { get; private set; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public Guid UserId { get; private set; }
	public User User { get; private set; }
}
