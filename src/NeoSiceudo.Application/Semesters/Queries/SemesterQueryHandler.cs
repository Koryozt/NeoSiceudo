using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Semesters.Queries.Statements;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Semesters.Queries;

public sealed class SemesterQueryHandler :
	IQueryHandler<GetAllSemestersQuery, IEnumerable<SemesterQueryResponse>>,
	IQueryHandler<GetSemestersByStudentQuery, IEnumerable<SemesterQueryResponse>>,
	IQueryHandler<GetSemesterByIdQuery, SemesterQueryResponse>,
	IQueryHandler<GetSemesterByNameQuery, SemesterQueryResponse>,
	IQueryHandler<GetSemesterByIdAdministrationQuery, Semester>
{
	public Task<Result<IEnumerable<SemesterQueryResponse>>> Handle(GetAllSemestersQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<IEnumerable<SemesterQueryResponse>>> Handle(GetSemestersByStudentQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<SemesterQueryResponse>> Handle(GetSemesterByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<SemesterQueryResponse>> Handle(GetSemesterByNameQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Semester>> Handle(GetSemesterByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
