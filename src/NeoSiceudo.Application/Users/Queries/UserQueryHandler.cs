using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Users.Queries.Statements;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Users.Queries;

public sealed class UserQueryHandler :
	IQueryHandler<GetAllUsersQuery, IEnumerable<UserQueryResponse>>,
	IQueryHandler<GetUsersByCareerQuery, IEnumerable<UserQueryResponse>>,
	IQueryHandler<GetUserByEmailQuery, UserQueryResponse>,
	IQueryHandler<GetUserByIdentityCardQuery, UserQueryResponse>,
	IQueryHandler<GetUserByIdQuery, UserQueryResponse>,
	IQueryHandler<GetUserByTaughtCourseQuery, UserQueryResponse>,
	IQueryHandler<IsEmailInUseQuery, bool>,
	IQueryHandler<GetUserByIdAdministrationQuery, User>
{
	private readonly IUserRepository _userRepository;

	public UserQueryHandler(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public Task<Result<IEnumerable<UserQueryResponse>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<IEnumerable<UserQueryResponse>>> Handle(GetUsersByCareerQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<UserQueryResponse>> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<UserQueryResponse>> Handle(GetUserByIdentityCardQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<UserQueryResponse>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<UserQueryResponse>> Handle(GetUserByTaughtCourseQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<bool>> Handle(IsEmailInUseQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<User>> Handle(GetUserByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
