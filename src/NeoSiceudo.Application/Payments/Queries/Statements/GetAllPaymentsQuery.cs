using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Payments.Queries.Statements;

public sealed record GetAllPaymentsQuery() : IQuery<IEnumerable<PaymentQueryResponse>>;