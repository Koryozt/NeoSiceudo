using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Payment;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Payments.Queries;

public sealed record PaymentQueryResponse(
	Guid Id,
	Name Subject,
	Reference Reference,
	DateTime Date,
	bool MadeOnline,
	User User);
