using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Payments.Queries.Statements;

public sealed record GetPaymentsByUserQuery(User User) : IQuery<IEnumerable<PaymentQueryResponse>>;