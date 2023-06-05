using System.Text;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.VerificationCode;

public sealed class Combination : ValueObject
{
	public string Value { get; private set; }
	private const string Separator = "-";
	private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
	private static Random _random = new();

	private Combination(string value)
	{
		Value = value;
	}

	private Combination() { }

	public static Result<Combination> Create(UserKeyPrefix keyPrefix, CareerKey key, Guid userId)
	{
		if (userId == Guid.Empty)
		{
			return Result.Failure<Combination>(DomainErrors.VerificationCode.Empty);
		}

		StringBuilder sb = new(keyPrefix.ToString() + Separator);

		string randstring = new string(Enumerable
			.Repeat(Characters, 16)
			.Select(s => s[_random.Next(s.Length)])
			.ToArray());

		string combined = sb.AppendJoin(Separator, key, userId, randstring).ToString();

		Combination comb = new(combined);

		return Result.Success(comb);
	}

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
