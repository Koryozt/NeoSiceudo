using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Domain.Entities;

public sealed class User : AggregateRoot, IAuditableEntity
{
	public User(Guid id) : base(id)
	{
		
	}

	public Name Firstname { get; private set; }
	public Name	Lastname { get; private set; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }
}
