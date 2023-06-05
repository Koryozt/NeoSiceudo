using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.VerificationCode;

namespace NeoSiceudo.Domain.Entities;

public sealed class VerificationCode : AggregateRoot, IAuditableEntity
{
	public VerificationCode(
		Guid id,
		Combination combination,
		User user) : base(id)
	{
		Combination = combination;
		Taken = false;
		User = user;
	}

	public Combination Combination { get; private set; }
	public bool Taken { get; private set; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public Guid UserId { get; private set; }
	public User User { get; private set; }

}
