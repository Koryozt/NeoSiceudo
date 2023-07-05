using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Abstractions;

public interface ITeacherRepository
{
	Task<IEnumerable<Teacher>> GetAllAsync(CancellationToken cancellationToken);
	Task<Teacher?> GetByTaughtCourseAsync(Course course, CancellationToken cancellationToken);
	Task<Teacher?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<Teacher?> GetByEmailAsync(Email email, CancellationToken cancellationToken);
	Task<Teacher?> GetByIdentityCardAsync(IdentityCard card, CancellationToken cancellationToken);
	Task AddAsync(Teacher student, CancellationToken cancellationToken);
	void Update(Teacher student);
}
