using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Users.Queries.Statements;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Users.Queries;

public sealed class StudentQueryHandler :
	IQueryHandler<GetAllStudentsQuery, IEnumerable<StudentQueryResponse>>,
	IQueryHandler<GetStudentsByCareerQuery, IEnumerable<StudentQueryResponse>>,
	IQueryHandler<GetStudentByEmailQuery, StudentQueryResponse>,
	IQueryHandler<GetStudentByIdentityCardQuery, StudentQueryResponse>,
	IQueryHandler<GetStudentByIdQuery, StudentQueryResponse>,
	IQueryHandler<GetStudentByIdAdministrationQuery, Student>
{

	public StudentQueryHandler()
	{

	}

	public Task<Result<IEnumerable<StudentQueryResponse>>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<IEnumerable<StudentQueryResponse>>> Handle(GetStudentsByCareerQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<StudentQueryResponse>> Handle(GetStudentByEmailQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<StudentQueryResponse>> Handle(GetStudentByIdentityCardQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<StudentQueryResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Student>> Handle(GetStudentByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
