using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Careers.Queries.Statements;

public sealed record GetCareerByIdAdministrationQuery(Guid id) : IQuery<Career>;
