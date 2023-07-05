using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Persistence.Repositories;

public class SemesterRepository : ISemesterRepository
{
	private readonly ApplicationDbContext _context;

	public SemesterRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Semester semester, CancellationToken cancellationToken) =>
		await _context
			.Set<Semester>()
			.AddAsync(semester, cancellationToken);

	public async Task<IEnumerable<Semester>> GetAllSemestersAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<Semester>()
			.ToListAsync(cancellationToken);

	public async Task<IEnumerable<Semester>> GetAllSemestersFromStudentAsync(User student, CancellationToken cancellationToken) =>
		await _context
			.Set<Semester>()
			.Where(s => s.SemesterStudent == student)
			.ToListAsync(cancellationToken);

	public async Task<Semester?> GetSemesterByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<Semester>()
			.Where(s => s.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Semester?> GetSemesterByNameAsync(Name name, CancellationToken cancellationToken) =>
		await _context
			.Set<Semester>()
			.Where(s => s.SemesterName == name)
			.FirstOrDefaultAsync(cancellationToken);

	public void Update(Semester semester) =>
		_context
			.Set<Semester>()
			.Update(semester);
}
