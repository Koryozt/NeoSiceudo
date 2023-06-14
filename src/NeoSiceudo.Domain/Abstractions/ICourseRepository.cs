using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Course;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Abstractions;

public interface ICourseRepository
{
	Task<IEnumerable<Course>> GetAllCoursesAsync(CancellationToken cancellationToken);
	Task<Course?> GetCourseByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<Course?> GetCourseByNameAsync(Name name, CancellationToken cancellationToken);
	Task<Course?> GetCourseByCodeAsync(Code code, CancellationToken cancellationToken);
	Task<Course?> GetCourseBySectionAsync(int section, CancellationToken cancellationToken);
	Task AddAsync(Course course, CancellationToken cancellationToken);
	void Update(Course course);
}
