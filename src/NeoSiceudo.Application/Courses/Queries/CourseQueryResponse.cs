using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Courses.Queries;

public sealed record CourseQueryResponse(
	Guid Id,
	Name Name,
	Code Code,
	User Teacher,
	int Credits,
	int Section,
	double Grade,
	IReadOnlyCollection<Information> Informations);