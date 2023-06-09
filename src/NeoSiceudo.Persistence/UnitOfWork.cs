﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Persistence;

public class UnitOfWork : IUnitOfWork
{
	private readonly ApplicationDbContext _context;

	public UnitOfWork(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
	{
		UpdateAuditableEntities();

		return await _context.SaveChangesAsync(cancellationToken);
	}

	private void UpdateAuditableEntities()
	{
		IEnumerable<EntityEntry<IAuditableEntity>> entries =
			_context
				.ChangeTracker
				.Entries<IAuditableEntity>();

		foreach (EntityEntry<IAuditableEntity> entityEntry in entries)
		{
			if (entityEntry.State == EntityState.Added)
			{
				entityEntry.Property(a => a.CreatedOnUtc)
					.CurrentValue = DateTime.UtcNow;
			}

			if (entityEntry.State == EntityState.Modified)
			{
				entityEntry.Property(a => a.LastModifiedUtc)
					.CurrentValue = DateTime.UtcNow;
			}
		}
	}
}
