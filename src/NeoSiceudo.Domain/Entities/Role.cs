using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Domain.Entities;


public sealed class Role : Enumeration<Role>
{
	public Role(int id, string name)
		: base(id, name)
	{

	}

	public ICollection<Permission> Permissions { get; set; }
	public ICollection<User> Users { get; set; }
}