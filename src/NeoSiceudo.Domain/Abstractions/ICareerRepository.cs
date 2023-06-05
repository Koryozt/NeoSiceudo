using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Abstractions;

public interface ICareerRepository
{
	Task<IEnumerable<Career>> GetAllAsync(CancellationToken cancellationToken);
	Task<Career?> GetCareerByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<Career?> GetCareerByNameAsync(Name name, CancellationToken cancellationToken);
	Task<Career?> GetCareerByKeyAsync(CareerKey key, CancellationToken cancellationToken);
	Task AddAsync(Career career, CancellationToken cancellationToken);
	void Update(Career career);

}
