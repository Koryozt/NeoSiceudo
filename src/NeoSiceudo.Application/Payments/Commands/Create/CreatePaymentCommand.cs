using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Payment;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Payments.Commands.Create;

public sealed record CreatePaymentCommand(
	Name Subject,
	Reference Reference,
	DateTime Date,
	bool MadeOnline,
	Guid UserId) : ICommand<Guid>;