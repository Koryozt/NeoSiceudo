using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Semester;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Semesters.Commands.Create;

public sealed record CreateSemesterCommand(
	Name Name,
	Year Year,
	Guid StudentId) : ICommand<Guid>;
