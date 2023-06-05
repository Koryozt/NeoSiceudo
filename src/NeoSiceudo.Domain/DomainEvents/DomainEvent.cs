using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Domain.DomainEvents;

public abstract record DomainEvent(Guid Id) : IDomainEvent;