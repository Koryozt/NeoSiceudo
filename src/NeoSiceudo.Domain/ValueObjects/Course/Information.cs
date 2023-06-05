using NeoSiceudo.Domain.Enumerators;
using NeoSiceudo.Domain.Errors;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.ValueObjects.Course;

public class Information : ValueObject
{
	public string Value { get; private set; }

	private Information(string value)
	{
		Value = value;
	}
	private Information() { }

	public static Result<Information> Create(
		int hour,
		DayOfWeek dayOfWeek,
		Classrooms classroom)
	{
		if (hour < 7 || hour > 17)
			return Result.Failure<Information>(DomainErrors.Information.InvalidHour);

		string val = $"{dayOfWeek} - {hour}:00 - {classroom}";

		Information info = new(val);

		return Result.Success(info);
	}

	public override IEnumerable<object> GetAtomicValues()
	{
		yield return Value;
	}
}
