using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Primitives;

public abstract class User : AggregateRoot, IAuditableEntity
{
	protected User(
		Guid id,
		Name firstname,
		Name lastname,
		Email email,
		Password password,
		IdentityCard identityCard,
		string? photo,
		DateTime birthday) : base(id)
	{
		Firstname = firstname;
		Lastname = lastname;
		Email = email;
		Password = password;
		IdentityCard = identityCard;
		Photo = photo;
		Birthday = birthday;
	}

	public Name Firstname { get; private set; }
	public Name Lastname { get; private set; }
	public Email Email { get; private set; }
	public Password Password { get; private set; }
	public IdentityCard IdentityCard { get; private set; }
	public string? Photo { get; private set; }
	public string Salt { get; init; }
	public DateTime Birthday { get; private set; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public VerificationCode VerificationCode { get; private set; }
	public ICollection<Role> Roles { get; set; }
}
