using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.User;

public sealed class IdentityCard : ValueObject
{
	public string Value { get; private set; }
	private const int MinLength = 7;
	private const int MaxLength = 9;

	private IdentityCard(string value)
	{
		Value = value;
	}

	private IdentityCard() { }

	public static Result<IdentityCard> Create(string value) =>
		Result.Create(value)
			.Ensure(e => !string.IsNullOrEmpty(e), 
				DomainErrors.IdentityCard.Empty)
			.Ensure(e => !e.Any(char.IsLetter), 
				DomainErrors.IdentityCard.Invalid)
			.Ensure(e => e.Length < MaxLength,
				DomainErrors.IdentityCard.TooLong)
			.Ensure(e => e.Length > MinLength, 
				DomainErrors.IdentityCard.TooShort)
			.Map(e => new IdentityCard(e));

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
