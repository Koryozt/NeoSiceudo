using NeoSiceudo.Application.Abstractions.Messaging;
using NeoSiceudo.Domain.Enumerators;

namespace NeoSiceudo.Application.Careers.Queries.Statements;

public sealed record GetCareerByKeyQuery(CareerKey Key) : IQuery<CareerQueryResponse>;