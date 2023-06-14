using FluentValidation;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Codes.Commands.Update;

public sealed class UpdateCodeCommandValidator : AbstractValidator<VerificationCode>
{
	public UpdateCodeCommandValidator()
	{
		RuleFor(e => e.Taken)
			.NotEmpty();
	}
}
