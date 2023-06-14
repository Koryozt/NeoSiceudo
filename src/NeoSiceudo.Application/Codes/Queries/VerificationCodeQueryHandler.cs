using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Codes.Queries.Statements;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Codes.Queries;

public sealed class VerificationCodeQueryHandler :
	IQueryHandler<GetAllCodesQuery, IEnumerable<VerificationCodeResponseQuery>>,
	IQueryHandler<GetCodeByCombinationQuery, VerificationCodeResponseQuery>,
	IQueryHandler<GetCodeByIdQuery, VerificationCodeResponseQuery>,
	IQueryHandler<GetCodeByIdAdministrationQuery, VerificationCode>,
	IQueryHandler<IsCodeValidQuery, bool>
{
	public Task<Result<IEnumerable<VerificationCodeResponseQuery>>> Handle(GetAllCodesQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<VerificationCodeResponseQuery>> Handle(GetCodeByCombinationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<VerificationCodeResponseQuery>> Handle(GetCodeByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<VerificationCode>> Handle(GetCodeByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<bool>> Handle(IsCodeValidQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
