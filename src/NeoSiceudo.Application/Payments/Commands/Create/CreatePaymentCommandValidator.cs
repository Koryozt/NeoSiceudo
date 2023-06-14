using FluentValidation;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Payment;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Payments.Commands.Create;

public sealed class CreatePaymentCommandValidator : AbstractValidator<Payment>
{
	public CreatePaymentCommandValidator()
	{
		RuleFor(e => e.Subject.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.Reference.Value)
			.NotEmpty()
			.Must(e => !e.Any(char.IsLetter))
			.MaximumLength(Reference.MaxLength);

		RuleFor(e => e.Date)
			.NotEmpty()
			.ExclusiveBetween(DateTime.MinValue, DateTime.Now);
	}
}
