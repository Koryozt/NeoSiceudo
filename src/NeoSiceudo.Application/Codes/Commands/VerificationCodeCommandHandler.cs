using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Codes.Commands.Create;
using NeoSiceudo.Application.Codes.Commands.Update;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Codes.Commands;

public sealed class VerificationCodeCommandHandler :
	ICommandHandler<CreateCodeCommand, Guid>,
	ICommandHandler<UpdateCodeCommand>
{
	private readonly IVerificationCodeRepository _codeRepository;
	private readonly IUnitOfWork _unitOfWork;

	public VerificationCodeCommandHandler(IVerificationCodeRepository codeRepository, IUnitOfWork unitOfWork)
	{
		_codeRepository = codeRepository;
		_unitOfWork = unitOfWork;
	}

	public Task<Result<Guid>> Handle(CreateCodeCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result> Handle(UpdateCodeCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
