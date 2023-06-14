using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Course;

namespace NeoSiceudo.Application.Courses.Commands.Update;

public sealed record UpdateCourseCommand(
	Guid Id,
	double Grade,
	List<Information> Information) : ICommand;