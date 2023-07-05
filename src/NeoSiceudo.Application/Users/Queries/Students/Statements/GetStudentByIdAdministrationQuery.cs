using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Application.Users.Queries.Statements;

public sealed record GetStudentByIdAdministrationQuery(Guid Id) : IQuery<Student>;
