using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.Course;

public sealed class Code : ValueObject
{
	public string Value { get; private set; }
	public const int MaxLength = 6;

	private Code(string value)
	{
		Value = value;
	}

	private Code() { }

	public static Result<Code> Create(string template) =>
		Result.Create(template)
			.Ensure(e => !string.IsNullOrEmpty(e),
				DomainErrors.Code.Empty)
			.Ensure(e => e.Length < MaxLength,
				DomainErrors.Code.TooLong)
			.Map(e => new Code(e));

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
