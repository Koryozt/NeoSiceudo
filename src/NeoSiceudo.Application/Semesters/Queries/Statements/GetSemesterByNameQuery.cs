using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Semesters.Queries.Statements;

public sealed record GetSemesterByNameQuery(Name Name) : IQuery<SemesterQueryResponse>;
