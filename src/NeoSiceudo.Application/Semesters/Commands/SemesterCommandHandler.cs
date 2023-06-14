using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Semesters.Commands.Create;
using NeoSiceudo.Application.Semesters.Commands.Update;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Semesters.Commands;

public sealed class SemesterCommandHandler :
	ICommandHandler<CreateSemesterCommand, Guid>,
	ICommandHandler<UpdateSemesterCommand>
{
	private readonly ISemesterRepository _semesterRepository;
	private readonly IUnitOfWork _uow;

	public SemesterCommandHandler(ISemesterRepository semesterRepository, IUnitOfWork uow)
	{
		_semesterRepository = semesterRepository;
		_uow = uow;
	}

	public Task<Result<Guid>> Handle(CreateSemesterCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result> Handle(UpdateSemesterCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
