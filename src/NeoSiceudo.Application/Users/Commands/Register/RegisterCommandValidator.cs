using FluentValidation;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Commands.Register;

public class RegisterCommandValidator : AbstractValidator<User>
{
	public RegisterCommandValidator()
	{
		RuleFor(e => e.Firstname.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.Lastname.Value)
			.NotEmpty()
			.MaximumLength(Name.MaxLength);

		RuleFor(e => e.IdentityCard.Value)
			.NotEmpty()
			.MaximumLength(IdentityCard.MaxLength)
			.MinimumLength(IdentityCard.MinLength);

		RuleFor(e => e.Email.Value)
			.NotEmpty()
			.EmailAddress()
			.MaximumLength(Email.MaxLength);

		RuleFor(e => e.Password.Value)
			.NotEmpty()
			.MinimumLength(Password.MinValue)
			.MaximumLength(Password.MaxValue);

		RuleFor(e => e.Birthday)
			.NotEmpty()
			.ExclusiveBetween(DateTime.Parse("1900-01-01"), DateTime.Now);
	}
}
