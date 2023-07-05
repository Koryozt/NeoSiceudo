using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Abstractions;

public interface ISemesterRepository
{
	Task<IEnumerable<Semester>> GetAllSemestersAsync(CancellationToken cancellationToken);
	Task<Semester?> GetSemesterByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<IEnumerable<Semester>> GetAllSemestersFromStudentAsync(User student, CancellationToken cancellationToken);
	Task<Semester?> GetSemesterByNameAsync(Name name, CancellationToken cancellationToken);
	Task AddAsync(Semester semester, CancellationToken cancellationToken);
	void Update(Semester semester);
}
