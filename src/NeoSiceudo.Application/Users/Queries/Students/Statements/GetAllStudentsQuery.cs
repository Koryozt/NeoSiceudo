using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetAllStudentsQuery() : IQuery<IEnumerable<StudentQueryResponse>>;
