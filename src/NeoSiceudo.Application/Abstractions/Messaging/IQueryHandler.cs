using MediatR;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse>
	: IRequestHandler<TQuery, Result<TResponse>>
	where TQuery : IQuery<TResponse>
{
}