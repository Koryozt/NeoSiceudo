using MediatR;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Application.Abstractions.Messaging;

public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent>
	where TEvent : IDomainEvent
{
}