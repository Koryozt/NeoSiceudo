using FluentValidation;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Semesters.Commands.Update;

public sealed class UpdateSemesterCommandValidator : AbstractValidator<Semester>
{
	public UpdateSemesterCommandValidator()
	{
		RuleFor(e => e.CoursesEnrolled)
			.NotEmpty()
			.Must(e => e.Sum(g => g.Credits) > 3);
	}
}
