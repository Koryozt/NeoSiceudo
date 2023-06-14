using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Commands.Update;
public sealed record UpdateUserCommand(
	Guid Id,
	Name Firstname,
	Name Lastname,
	Email Email,
	string Photo) : ICommand;
