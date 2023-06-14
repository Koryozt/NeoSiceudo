using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Codes.Queries.Statements;

public sealed record GetAllCodesQuery() : IQuery<IEnumerable<VerificationCodeResponseQuery>>;
