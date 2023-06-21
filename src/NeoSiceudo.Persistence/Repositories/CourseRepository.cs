using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;
namespace NeoSiceudo.Persistence.Repositories;

public class CourseRepository : ICourseRepository
{
	private readonly ApplicationDbContext _context;

	public CourseRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Course course, CancellationToken cancellationToken) =>
		await _context
			.Set<Course>()
			.AddAsync(course, cancellationToken);

	public async Task<IEnumerable<Course>> GetAllCoursesAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<Course>()
			.ToListAsync();

	public async Task<Course?> GetCourseByCodeAsync(Code code, CancellationToken cancellationToken) =>
		await _context
			.Set<Course>()
			.Where(c => c.Code == code)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Course?> GetCourseByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<Course>()
			.Where(c => c.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Course?> GetCourseByNameAsync(Name name, CancellationToken cancellationToken) =>
		await _context
			.Set<Course>()
			.Where(c => c.Name == name)
			.FirstOrDefaultAsync(cancellationToken);
	public async Task<Course?> GetCourseBySectionAsync(int section, CancellationToken cancellationToken) =>
		await _context
			.Set<Course>()
			.Where(c => c.Section == section)
			.FirstOrDefaultAsync(cancellationToken);

	public void Update(Course course) =>
		_context
			.Set<Course>()
			.Update(course);
}
