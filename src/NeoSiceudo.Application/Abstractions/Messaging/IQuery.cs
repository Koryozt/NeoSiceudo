using MediatR;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}