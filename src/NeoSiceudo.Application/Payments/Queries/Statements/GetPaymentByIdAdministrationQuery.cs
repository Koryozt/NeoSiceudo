using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Payments.Queries.Statements;

public sealed record GetPaymentByIdAdministrationQuery(Guid Id) : IQuery<Payment>;