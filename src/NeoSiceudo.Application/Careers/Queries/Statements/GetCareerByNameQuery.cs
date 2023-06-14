using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Careers.Queries.Statements;

public sealed record GetCareerByNameQuery(Name Name) : IQuery<CareerQueryResponse>;
