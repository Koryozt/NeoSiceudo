﻿namespace NeoSiceudo.Domain.Primitives;

public interface IAuditableEntity
{
	DateTime CreatedOnUtc { get; init; }
	DateTime? LastModifiedUtc { get; set; }
}