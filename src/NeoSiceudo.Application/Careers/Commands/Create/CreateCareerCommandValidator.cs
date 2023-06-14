using FluentValidation;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Careers.Commands.Create;

public sealed class CreateCareerCommandValidator : AbstractValidator<Career>
{
	public CreateCareerCommandValidator()
	{
		RuleFor(e => e.Name.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength)
			.Must(e => e.Any(char.IsDigit) is not true);

		RuleFor(e => e.BossName.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength)
			.Must(e => e.Any(char.IsDigit) is not true);

		RuleFor(e => e.CreditsToComplete)
			.NotEmpty()
			.GreaterThanOrEqualTo(1)
			.LessThanOrEqualTo(500);

		RuleFor(e => e.DepartmentLocation)
			.NotEmpty();

		RuleFor(e => e.Key)
			.NotEmpty()
			.IsInEnum();
	}
}
