using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Persistence.Repositories;

public class UserRepository : IUserRepository
{
	private readonly ApplicationDbContext _context;

	public UserRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(User user, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.AddAsync(user, cancellationToken);

	public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.ToListAsync(cancellationToken);

	public async Task<User?> GetByEmailAsync(Email email, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.Where(u => u.Email == email)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.Where(u => u.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<IEnumerable<User>> GetUsersByCareerAsync(Career career, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.Where(u => u.Careers.Contains(career))
			.ToListAsync(cancellationToken);

	public async Task<User?> GetUserByIdentityCardAsync(IdentityCard card, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.Where(u => u.IdentityCard == card)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<User?> GetUserByTaughtCourseAsync(Course course, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.Where(u => u.CoursesTaught.Contains(course))
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<bool> IsEmailInUseAsync(Email email, CancellationToken cancellationToken) =>
		await _context
			.Set<User>()
			.AnyAsync(e => e.Email == email, cancellationToken);

	public void Update(User user) =>
		_context
			.Set<User>()
			.Update(user);
}
