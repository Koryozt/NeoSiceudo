using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.Semester;

public sealed class Year : ValueObject
{
	public int Value { get; private set; }

	public Year(int value)
	{
		Value = value;
	}

	public static Result<Year> Create(int value) =>
		Result.Create(value)
			.Ensure(e => e == DateTime.Now.Year,
				DomainErrors.Year.Invalid)
			.Map(e => new Year(e));

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
