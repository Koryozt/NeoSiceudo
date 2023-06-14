using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Commands.Register;

public sealed record RegisterCommand(
		Name Firstname,
		Name Lastname,
		Email Email,
		Password Password,
		IdentityCard IdentityCard,
		string? Photo,
		DateTime Birthday) : ICommand<Guid>;