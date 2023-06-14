using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Payment;

namespace NeoSiceudo.Application.Payments.Queries.Statements;

public sealed record GetPaymentByReferenceQuery(Reference Reference) : IQuery<PaymentQueryResponse>;

