using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Persistence.Repositories;

public class StudentRepository : IStudentRepository
{
	private readonly ApplicationDbContext _context;

	public StudentRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Student student, CancellationToken cancellationToken) =>
		await _context
			.Set<Student>()
			.AddAsync(student, cancellationToken);

	public async Task<IEnumerable<Student>> GetAllAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<Student>()
			.ToListAsync(cancellationToken);

	public async Task<Student?> GetByEmailAsync(Email email, CancellationToken cancellationToken) =>
		await _context
			.Set<Student>()
			.Where(u => u.Email == email)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Student?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<Student>()
			.Where(u => u.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<IEnumerable<Student>> GetByCareerAsync(Career career, CancellationToken cancellationToken) =>
		await _context
			.Set<Student>()
			.Where(u => u.Careers.Contains(career))
			.ToListAsync(cancellationToken);

	public async Task<Student?> GetByIdentityCardAsync(IdentityCard card, CancellationToken cancellationToken) =>
		await _context
			.Set<Student>()
			.Where(u => u.IdentityCard == card)
			.FirstOrDefaultAsync(cancellationToken);

	public void Update(Student student) =>
		_context
			.Set<Student>()
			.Update(student);
}
