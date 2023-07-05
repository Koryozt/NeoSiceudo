using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Abstractions;

public interface IStudentRepository
{
	Task<IEnumerable<Student>> GetAllAsync(CancellationToken cancellationToken);
	Task<IEnumerable<Student>> GetByCareerAsync(Career Career, CancellationToken cancellationToken);
	Task<Student?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<Student?> GetByEmailAsync(Email email, CancellationToken cancellationToken);
	Task<Student?> GetByIdentityCardAsync(IdentityCard card, CancellationToken cancellationToken);
	Task AddAsync(Student student, CancellationToken cancellationToken);
	void Update(Student student);
}
