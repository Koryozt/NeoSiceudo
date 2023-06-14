using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Courses.Queries.Statements;

public sealed record GetCourseByIdAdministrationQuery(Guid Id) : IQuery<Course>;
