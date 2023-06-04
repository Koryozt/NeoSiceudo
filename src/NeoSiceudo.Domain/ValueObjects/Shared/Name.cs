using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.Shared;

public sealed class Name : ValueObject
{
	public const int MaxLength = 50;
	public string Value { get; private set; }

	private Name(string value)
	{
		Value = value;
	}

	private Name()
	{

	}

	public static Result<Name> Create(string firstName)
	{
		if (string.IsNullOrWhiteSpace(firstName))
		{
			return Result.Failure<Name>
				(DomainErrors.Name.Empty);
		}

		if (firstName.Length > MaxLength)
		{
			return Result.Failure<Name>
				(DomainErrors.Name.TooLong);
		}

		var firstname = new Name(firstName);

		return Result.Success(firstname);
	}

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
