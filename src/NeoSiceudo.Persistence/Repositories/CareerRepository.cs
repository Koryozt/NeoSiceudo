using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Persistence.Repositories;

public class CareerRepository : ICareerRepository
{
	private readonly ApplicationDbContext _context;

	public CareerRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Career career, CancellationToken cancellationToken) =>
		await _context
			.Set<Career>()
			.AddAsync(career, cancellationToken);

	public async Task<IEnumerable<Career>> GetAllAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<Career>()
			.ToListAsync(cancellationToken);

	public async Task<Career?> GetCareerByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<Career>()
			.Where(c => c.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Career?> GetCareerByKeyAsync(CareerKey key, CancellationToken cancellationToken) =>
		await _context
			.Set<Career>()
			.Where(c => c.Key == key)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Career?> GetCareerByNameAsync(Name name, CancellationToken cancellationToken) =>
		await _context
			.Set<Career>()
			.Where(c => c.Name == name)
			.FirstOrDefaultAsync(cancellationToken);

	public void Update(Career career) =>
		_context
			.Set<Career>()
			.Update(career);
}
