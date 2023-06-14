using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.ValueObjects.Shared;

namespace NeoSiceudo.Application.Careers.Queries;

public sealed record CareerQueryResponse(
	Guid Id,
	Name Name,
	Name BossName,
	CareerKey Key,
	string DepartmentLocation,
	int CreditsToComplete,
	IEnumerable<Course> Courses);