using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Courses.Queries.Statements;

public sealed record GetCourseBySectionQuery(int Section) : IQuery<CourseQueryResponse>;
