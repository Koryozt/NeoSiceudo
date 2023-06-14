using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Courses.Queries.Statements;

public sealed record GetCourseByIdQuery(Guid Id) : IQuery<CourseQueryResponse>;
