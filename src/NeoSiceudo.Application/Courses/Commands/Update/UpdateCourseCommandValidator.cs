using FluentValidation;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Courses.Commands.Update;

public sealed class UpdateCourseCommandValidator : AbstractValidator<Course>
{
	public UpdateCourseCommandValidator()
	{
		RuleFor(e => e.Id)
			.NotEmpty();

		RuleFor(e => e.Credits)
			.NotEmpty()
			.GreaterThanOrEqualTo(1);

		RuleFor(e => e.Information)
			.Must(e => e.Count > 0);
	}
}
