using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetUserByEmailQuery(Email Email) : IQuery<UserQueryResponse>;
