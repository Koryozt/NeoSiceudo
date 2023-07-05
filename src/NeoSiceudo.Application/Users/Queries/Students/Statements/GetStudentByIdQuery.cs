using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetStudentByIdQuery(Guid Id) : IQuery<StudentQueryResponse>;
