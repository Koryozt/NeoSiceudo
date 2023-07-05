using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Users.Queries.Statements;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Users.Queries;

public sealed class TeacherQueryHandler :
	IQueryHandler<GetAllTeachersQuery, IEnumerable<TeacherQueryResponse>>,
	IQueryHandler<GetTeacherByEmailQuery, TeacherQueryResponse>,
	IQueryHandler<GetTeacherByIdentityCardQuery, TeacherQueryResponse>,
	IQueryHandler<GetTeacherByIdQuery, TeacherQueryResponse>,
	IQueryHandler<GetTeacherByIdAdministrationQuery, Teacher>
{
	public Task<Result<IEnumerable<TeacherQueryResponse>>> Handle(GetAllTeachersQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<TeacherQueryResponse>> Handle(GetTeacherByEmailQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<TeacherQueryResponse>> Handle(GetTeacherByIdentityCardQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<TeacherQueryResponse>> Handle(GetTeacherByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Teacher>> Handle(GetTeacherByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
