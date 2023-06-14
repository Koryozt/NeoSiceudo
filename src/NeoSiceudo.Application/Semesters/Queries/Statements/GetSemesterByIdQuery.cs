using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Semesters.Queries.Statements;

public sealed record GetSemesterByIdQuery(Guid Id) : IQuery<SemesterQueryResponse>;