using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Domain.Entities;

public sealed class Career : AggregateRoot, IAuditableEntity
{
	public Career(
		Guid id,
		Name name,
		Name bossName,
		CareerKey key,
		string departmentLocation,
		int creditsToComplete
		) : base(id)
	{
		Name = name;
		BossName = bossName;
		Key = key;
		DepartmentLocation = departmentLocation;
		CreditsToComplete = creditsToComplete;
	}

	public Name Name { get; private set; }
	public Name BossName { get; private set; }
	public CareerKey Key { get; private set; }
	public string DepartmentLocation { get; private set; }
	public int CreditsToComplete { get; init; }
	public DateTime CreatedOnUtc { get; init; }
	public DateTime? LastModifiedUtc { get; set; }

	public ICollection<User> Students { get; set; }
}
