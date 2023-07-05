using NeoSiceudo.Application.Abstractions;
using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Users.Commands.Login;
using NeoSiceudo.Application.Users.Commands.Register;
using NeoSiceudo.Application.Users.Commands.Update;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Users.Commands;

public sealed class UserCommandHandler :
	ICommandHandler<RegisterCommand, Guid>,
	ICommandHandler<LoginCommand, string>,
	ICommandHandler<UpdateUserCommand>
{
	private readonly IStudentRepository _studentRepository;
	private readonly ITeacherRepository _teacherRepository;
	private readonly IUnitOfWork _uow;
	private readonly IJwtProvider _provider;

	public UserCommandHandler(
		IStudentRepository studentRepository,
		IUnitOfWork uow,
		IJwtProvider provider,
		ITeacherRepository teacherRepository)
	{
		_studentRepository = studentRepository;
		_uow = uow;
		_provider = provider;
		_teacherRepository = teacherRepository;
	}

	public Task<Result<Guid>> Handle(RegisterCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
