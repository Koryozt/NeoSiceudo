using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Course;

namespace NeoSiceudo.Application.Courses.Queries.Statements;

public sealed record GetCourseByCodeQuery(Code Code) : IQuery<CourseQueryResponse>;