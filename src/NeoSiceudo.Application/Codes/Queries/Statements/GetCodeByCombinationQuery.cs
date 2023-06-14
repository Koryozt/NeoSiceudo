using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.VerificationCode;

namespace NeoSiceudo.Application.Codes.Queries.Statements;

public sealed record GetCodeByCombinationQuery(Combination Combination) : IQuery<VerificationCodeResponseQuery>;
