using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetStudentsByCareerQuery(Career Career) : IQuery<IEnumerable<StudentQueryResponse>>;
