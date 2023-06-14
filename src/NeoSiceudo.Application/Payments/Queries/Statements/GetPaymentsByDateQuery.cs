using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Payments.Queries.Statements;

public sealed record GetPaymentsByDateQuery(DateTime Date) : IQuery<IEnumerable<PaymentQueryResponse>>;