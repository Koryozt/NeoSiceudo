using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Courses.Queries.Statements;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Courses.Queries;

public sealed class CourseQueryHandler :
	IQueryHandler<GetCourseByIdQuery, CourseQueryResponse>,
	IQueryHandler<GetCourseByCodeQuery, CourseQueryResponse>,
	IQueryHandler<GetCourseByNameQuery, CourseQueryResponse>,
	IQueryHandler<GetCourseBySectionQuery, CourseQueryResponse>,
	IQueryHandler<GetCourseByIdAdministrationQuery, Course>
{
	public Task<Result<CourseQueryResponse>> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<CourseQueryResponse>> Handle(GetCourseByCodeQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<CourseQueryResponse>> Handle(GetCourseByNameQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<CourseQueryResponse>> Handle(GetCourseBySectionQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result<Course>> Handle(GetCourseByIdAdministrationQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
