using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Careers.Commands.Create;

public sealed record CreateCareerCommand(
	Name Name,
	Name BossName,
	CareerKey Key,
	string DepartmentLocation,
	int CreditsToComplete) : ICommand<Guid>;