using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetAllTeachersQuery() : IQuery<IEnumerable<TeacherQueryResponse>>;
