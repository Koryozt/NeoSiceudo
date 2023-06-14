using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Application.Courses.Commands.Create;
using NeoSiceudo.Application.Users.Commands.Update;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Courses.Commands;

public sealed class CourseCommandHandler :
	ICommandHandler<CreateCourseCommand, Guid>,
	ICommandHandler<UpdateUserCommand>
{
	private readonly ICourseRepository _courseRepository;
	private readonly IUnitOfWork _uow;

	public CourseCommandHandler(ICourseRepository courseRepository, IUnitOfWork uow)
	{
		_courseRepository = courseRepository;
		_uow = uow;
	}

	public Task<Result<Guid>> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<Result> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
