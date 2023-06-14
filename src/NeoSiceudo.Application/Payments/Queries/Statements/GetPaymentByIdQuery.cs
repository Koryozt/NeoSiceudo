using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Payments.Queries.Statements;

public sealed record GetPaymentByIdQuery(Guid Id) : IQuery<PaymentQueryResponse>;