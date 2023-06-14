using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Queries;

public sealed record UserQueryResponse(
	Guid Id,
	Name Firstname,
	Name Lastname,
	Email Email,
	Password Password,
	IdentityCard IdentityCard,
	string Photo,
	DateTime Birthday,
	double AverageGrade,
	IEnumerable<Career> Careers,
	IEnumerable<Semester> Semesters,
	ICollection<Course> CoursesTaught
	);
