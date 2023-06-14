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
	private readonly IUserRepository _userRepository;
	private readonly IUnitOfWork _uow;
	private readonly IJwtProvider _provider;

	public UserCommandHandler(
		IUserRepository userRepository,
		IUnitOfWork uow,
		IJwtProvider provider)
	{
		_userRepository = userRepository;
		_uow = uow;
		_provider = provider;
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
