using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Careers.Commands.Update;

public sealed record UpdateCareerCommand(
	Guid Id,
	Name BossName,
	int CreditsToComplete) : ICommand;