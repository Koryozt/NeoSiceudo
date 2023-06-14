using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Courses.Queries.Statements;

public sealed record GetCourseByNameQuery(Name Name) : IQuery<CourseQueryResponse>;
