using FluentValidation;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Courses.Commands.Create;

public sealed class CreateCourseCommandValidator : AbstractValidator<Course>
{
	public CreateCourseCommandValidator()
	{
		RuleFor(e => e.Name.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.Code.Value)
			.NotEmpty()
			.MaximumLength(Code.MaxLength);

		RuleFor(e => e.Teacher)
			.NotEmpty();

		RuleFor(e => e.Section)
			.NotEmpty()
			.GreaterThanOrEqualTo(1);

		RuleFor(e => e.Credits)
			.NotEmpty()
			.GreaterThanOrEqualTo(1);
	}
}
