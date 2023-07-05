using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Domain.Entities;

public sealed class Teacher	: User
{
	public Teacher(
		Guid id, 
		Name firstname, 
		Name lastname, 
		Email email, 
		Password password, 
		IdentityCard identityCard, 
		string? photo, 
		DateTime birthday, 
		Name degree,
		bool isBoos) : base(
			id, firstname, lastname, email, password, identityCard, photo, birthday)
	{
		Degree = degree;
		IsBoss = isBoos;
	}

	public Name Degree { get; private set; }
	public bool IsBoss { get; private set; }

	public ICollection<Course> CoursesTaught { get; set; }
}
