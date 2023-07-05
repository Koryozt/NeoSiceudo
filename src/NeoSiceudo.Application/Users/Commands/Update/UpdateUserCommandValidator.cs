using FluentValidation;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Commands.Update;

internal class UpdateUserCommandValidator : AbstractValidator<User>
{
	public UpdateUserCommandValidator()
	{
		RuleFor(e => e.Firstname.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.Lastname.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.Email.Value)
			.NotEmpty()
			.EmailAddress()
			.MaximumLength(Email.MaxLength);
	}
}