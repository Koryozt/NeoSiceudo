using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Domain.DomainEvents;

public abstract record DomainEvent(Guid Id) : IDomainEvent;