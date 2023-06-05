using NeoSiceudo.Domain.Shared;

namespace NeoSiceudo.Domain.Errors;

public static class DomainErrors
{
	public static class Name
	{
		public static readonly Error Empty = new(
			"Name.Empty",
			"Name contains a null or empty value");

		public static readonly Error TooLong = new(
			"Name.TooLong",
			"Name exceeded the maximum characters capacity.");
	}

	public static class Email
	{
		public static readonly Error Empty = new(
			"Email.Empty",
			"Email is empty");

		public static readonly Error TooLong = new(
			"Email.TooLong",
			"Email is too long");

		public static readonly Error InvalidFormat = new(
			"Email.InvalidFormat",
			"Email format is invalid");
	}

	public static class Year
	{
		public static readonly Error Invalid = new(
			"Year.Invalid",
			$"The year is not equal as {DateTime.Now.Year}");
	}

	public static class Password
	{
		public static readonly Error Empty = new(
			"Password.Empty",
			"Password is empty");

		public static readonly Error TooShort = new(
			"Password.TooShort",
			"Password too short. The minimum permitted are 8 characters");

		public static readonly Error TooLong = new(
			"Password.TooLong",
			"Password too long. The maximum permitted are 32 characters");

		public static readonly Error Invalid = new(
			"Password.Invalid",
			"The password must contain uppercase, lowercase, numbers and special characters");
	}

	public static class Information
	{
		public static readonly Error InvalidHour = new(
			"Information.InvalidHour",
			"Time must be between 7:00 and 17:00");
	}

	public static class Code
	{
		public static readonly Error Empty = new(
			"Code.Empty",
			"Code is empty");

		public static readonly Error TooLong = new(
			"Code.TooLong",
			"Code exceeded the 6 characters permitted");
	}

	public static class VerificationCode
	{
		public static readonly Error Empty = new(
			"VerificationCode.Empty",
			"VerificationCode is empty");
	}

	public static class Reference
	{
		public static readonly Error Empty = new(
			"Reference.Empty",
			"Reference is empty");

		public static readonly Error TooLong = new(
			"Reference.TooLong",
			"Reference too long. The maximum permitted are 14 characters");

		public static readonly Error Invalid = new(
			"Reference.Invalid",
			"The reference can only contain numeric characters");
	}

	public static class IdentityCard
	{
		public static readonly Error Empty = new(
			"IdentityCard.Empty",
			"Identity card is empty");

		public static readonly Error TooShort = new(
			"IdentityCard.TooShort",
			"Identity card too short. The minimum permitted are 7 characters");

		public static readonly Error TooLong = new(
			"IdentityCard.TooLong",
			"Identity card too long. The maximum permitted are 9 characters");

		public static readonly Error Invalid = new(
			"IdentityCard.Invalid",
			"The Identity card can only contain numeric characters");
	}
}