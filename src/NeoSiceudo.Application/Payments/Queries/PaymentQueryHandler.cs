using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Payments.Queries.Statements;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Payments.Queries;

public sealed class PaymentQueryHandler :
	IQueryHandler<GetAllPaymentsQuery, IEnumerable<PaymentQueryResponse>>,
	IQueryHandler<GetPaymentsByDateQuery, IEnumerable<PaymentQueryResponse>>,
	IQueryHandler<GetPaymentsByUserQuery, IEnumerable<PaymentQueryResponse>>,
	IQueryHandler<GetPaymentByIdQuery, PaymentQueryResponse>,
	IQueryHandler<GetPaymentByIdAdministrationQuery, Payment>
{
	public Task<Result<IEnumerable<PaymentQueryResponse>>> Handle(GetAllPaymentsQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<IEnumerable<PaymentQueryResponse>>> Handle(GetPaymentsByDateQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<IEnumerable<PaymentQueryResponse>>> Handle(GetPaymentsByUserQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<PaymentQueryResponse>> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Payment>> Handle(GetPaymentByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
