using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Application.Semesters.Queries.Statements;

public sealed record GetSemestersByStudentQuery(User Student) : IQuery<IEnumerable<SemesterQueryResponse>>;