using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetUsersByCareerQuery(Career Career) : IQuery<IEnumerable<UserQueryResponse>>;
