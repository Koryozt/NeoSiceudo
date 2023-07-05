using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Persistence.Repositories;
public class TeacherRepository : ITeacherRepository 
{
	private readonly ApplicationDbContext _context;

	public TeacherRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Teacher teacher, CancellationToken cancellationToken) =>
		await _context
			.Set<Teacher>()
			.AddAsync(teacher, cancellationToken);

	public async Task<IEnumerable<Teacher>> GetAllAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<Teacher>()
			.ToListAsync(cancellationToken);

	public async Task<Teacher?> GetByEmailAsync(Email email, CancellationToken cancellationToken) =>
		await _context
			.Set<Teacher>()
			.Where(u => u.Email == email)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Teacher?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<Teacher>()
			.Where(u => u.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Teacher?> GetByTaughtCourseAsync(Course course, CancellationToken cancellationToken) =>
		await _context
			.Set<Teacher>()
			.Where(u => u.CoursesTaught.Contains(course))
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Teacher?> GetByIdentityCardAsync(IdentityCard card, CancellationToken cancellationToken) =>
		await _context
			.Set<Teacher>()
			.Where(u => u.IdentityCard == card)
			.FirstOrDefaultAsync(cancellationToken);

	public void Update(Teacher teacher) =>
		_context
			.Set<Teacher>()
			.Update(teacher);
}
