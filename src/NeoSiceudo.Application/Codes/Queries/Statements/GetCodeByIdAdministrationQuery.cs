using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Codes.Queries.Statements;

public sealed record GetCodeByIdAdministrationQuery(Guid Id) : IQuery<VerificationCode>;