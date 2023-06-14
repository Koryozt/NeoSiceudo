using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Payments.Commands.Create;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Payments.Commands;

public sealed class PaymentCommandHandler :
	ICommandHandler<CreatePaymentCommand, Guid>
{
	private readonly IPaymentRepository _paymentRepository;
	private readonly IUnitOfWork _uow;

	public PaymentCommandHandler(IPaymentRepository paymentRepository, IUnitOfWork uow)
	{
		_paymentRepository = paymentRepository;
		_uow = uow;
	}

	public Task<Result<Guid>> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
