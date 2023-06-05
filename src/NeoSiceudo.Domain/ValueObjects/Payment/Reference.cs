using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.Payment;

public sealed class Reference : ValueObject
{
	public const int MaxLength = 14;
	public string Value { get; private set; }

	private Reference(string value)
	{
		Value = value;
	}

	private Reference()
	{

	}

	public static Result<Reference> Create(string value) =>
		Result.Create(value)
			.Ensure(e => !string.IsNullOrEmpty(e),
				DomainErrors.Reference.Empty)
			.Ensure(e => !e.Any(char.IsLetter),
				DomainErrors.Reference.Invalid)
			.Ensure(e => e.Length < MaxLength,
				DomainErrors.Reference.TooLong)
			.Map(e => new Reference(e));

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
