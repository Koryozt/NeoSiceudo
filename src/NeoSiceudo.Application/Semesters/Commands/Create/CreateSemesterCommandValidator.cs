using FluentValidation;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Semesters.Commands.Create;

public sealed class CreateSemesterCommandValidator : AbstractValidator<Semester>
{
	public CreateSemesterCommandValidator()
	{
		RuleFor(e => e.SemesterName.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.Year.Value)
			.NotEmpty()
			.GreaterThanOrEqualTo(2000)
			.LessThanOrEqualTo(DateTime.Now.Year);

		RuleFor(e => e.SemesterStudentId)
			.NotEmpty();
	}
}
