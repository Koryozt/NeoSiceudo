using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Shared;
using NeoSiceudo.Domain.ValueObjects.User;

namespace NeoSiceudo.Application.Users.Queries;

public sealed record TeacherQueryResponse(
	Guid Id,
	Name Firstname,
	Name Lastname,
	Email Email,
	Password Password,
	IdentityCard IdentityCard,
	string Photo,
	DateTime Birthday,
	double AverageGrade,
	Name Degree,
	bool IsBoos,
	ICollection<Course> CoursesTaught
	);
