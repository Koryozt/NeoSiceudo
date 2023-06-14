using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Careers.Commands.Create;
using NeoSiceudo.Application.Careers.Commands.Update;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Careers.Commands;

public sealed class CareerCommandHandler :
	ICommandHandler<CreateCareerCommand, Guid>,
	ICommandHandler<UpdateCareerCommand>
{
	private readonly ICareerRepository _careerRepository;
	private readonly IUnitOfWork _uow;

	public CareerCommandHandler(ICareerRepository careerRepository, IUnitOfWork uow)
	{
		_careerRepository = careerRepository;
		_uow = uow;
	}


	public Task<Result<Guid>> Handle(CreateCareerCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result> Handle(UpdateCareerCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
