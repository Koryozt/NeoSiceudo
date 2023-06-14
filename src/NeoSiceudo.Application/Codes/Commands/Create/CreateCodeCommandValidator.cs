using FluentValidation;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Codes.Commands.Create;

public sealed class CreateCodeCommandValidator : AbstractValidator<VerificationCode>
{
	public CreateCodeCommandValidator()
	{
		RuleFor(e => e.Combination.Value)
			.NotEmpty();

		RuleFor(e => e.UserId)
			.NotEmpty();
	}
}
