using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Codes.Queries.Statements;

public sealed record GetCodeByIdQuery(Guid Id) : IQuery<VerificationCodeResponseQuery>;