using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.VerificationCode;

namespace NeoSiceudo.Application.Codes.Commands.Create;

public sealed record CreateCodeCommand(
	Combination Combination,
	Guid UserId) : ICommand<Guid>;