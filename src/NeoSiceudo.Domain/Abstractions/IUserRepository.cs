using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Abstractions;

public interface IUserRepository
{
	Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken);
	Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<User?> GetByEmailAsync(Email email, CancellationToken cancellationToken);
	Task<User?> GetUserByIdentityCardAsync(IdentityCard card, CancellationToken cancellationToken);
	Task<User?> GetUserByCareerAsync(Career career, CancellationToken cancellationToken);
	Task<User?> GetUserByTaughtCourseAsync(Course course, CancellationToken cancellationToken);
	Task<bool> IsEmailInUseAsync(Email email, CancellationToken cancellationToken);
	Task AddAsync(User user, CancellationToken cancellationToken);
	void Update(User user);
}