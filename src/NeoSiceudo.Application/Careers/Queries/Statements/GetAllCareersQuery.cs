using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Careers.Queries.Statements;

public sealed record GetAllCareersQuery() : IQuery<IEnumerable<CareerQueryResponse>>;
