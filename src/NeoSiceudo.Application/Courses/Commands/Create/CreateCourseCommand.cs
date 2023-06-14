using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Courses.Commands.Create;

public sealed record CreateCourseCommand(
	Name Name,
	Code Code,
	Guid TeacherId,
	int Credits,
	int Section) : ICommand<Guid>;