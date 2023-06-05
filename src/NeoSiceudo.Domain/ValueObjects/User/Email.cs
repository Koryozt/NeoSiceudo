﻿using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.User;

public sealed class Email : ValueObject
{
	public const int MaxLength = 255;

	private Email(string value) => Value = value;

	private Email()
	{
	}

	public string Value { get; private set; }

	public static Result<Email> Create(string email) =>
		Result.Create(email)
			.Ensure(
				e => !string.IsNullOrWhiteSpace(e),
				DomainErrors.Email.Empty)
			.Ensure(
				e => e.Length <= MaxLength,
				DomainErrors.Email.TooLong)
			.Ensure(
				e => e.Split('@').Length == 2,
				DomainErrors.Email.InvalidFormat)
			.Map(e => new Email(e));

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}