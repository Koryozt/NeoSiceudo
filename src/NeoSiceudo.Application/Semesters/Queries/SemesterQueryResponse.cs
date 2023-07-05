using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Semester;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Semesters.Queries;

public sealed record SemesterQueryResponse(
	Guid Id,
	Name Name,
	Year Year,
	User Student,
	double AverageGrade,
	IEnumerable<Course> CoursesEnrolled);
