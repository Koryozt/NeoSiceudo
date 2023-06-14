using FluentValidation;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Careers.Commands.Update;

public sealed class UpdateCareerCommandValidator : AbstractValidator<Career>
{
	public UpdateCareerCommandValidator()
	{
		RuleFor(e => e.BossName.Value)
		.NotEmpty()
		.MaximumLength(Name.MaxLength)
		.Must(e => e.Any(char.IsDigit) is not true);

		RuleFor(e => e.CreditsToComplete)
			.NotEmpty()
			.GreaterThanOrEqualTo(1)
			.LessThanOrEqualTo(500);
	}
}
