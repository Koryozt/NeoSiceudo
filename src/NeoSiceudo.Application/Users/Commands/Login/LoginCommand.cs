using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Commands.Login;

public sealed record LoginCommand(
	Email Email,
	IdentityCard IdentityCard,
	Password Password) : ICommand<string>;