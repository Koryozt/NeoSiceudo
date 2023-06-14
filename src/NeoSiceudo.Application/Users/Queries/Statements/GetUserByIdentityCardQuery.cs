using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetUserByIdentityCardQuery(IdentityCard IdentityCard) : IQuery<UserQueryResponse>;
