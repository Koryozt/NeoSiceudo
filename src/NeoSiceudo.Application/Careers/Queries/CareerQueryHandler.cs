using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Careers.Queries.Statements;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Careers.Queries;

public sealed class CareerQueryHandler :
	IQueryHandler<GetAllCareersQuery, IEnumerable<CareerQueryResponse>>,
	IQueryHandler<GetCareerByIdQuery, CareerQueryResponse>,
	IQueryHandler<GetCareerByKeyQuery, CareerQueryResponse>,
	IQueryHandler<GetCareerByNameQuery, CareerQueryResponse>,
	IQueryHandler<GetCareerByIdAdministrationQuery, Career>
{
	private readonly ICareerRepository _careerRepository;

	public CareerQueryHandler(ICareerRepository careerRepository)
	{
		_careerRepository = careerRepository;
	}

	public Task<Result<IEnumerable<CareerQueryResponse>>> Handle(GetAllCareersQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<CareerQueryResponse>> Handle(GetCareerByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<CareerQueryResponse>> Handle(GetCareerByKeyQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<CareerQueryResponse>> Handle(GetCareerByNameQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Career>> Handle(GetCareerByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
