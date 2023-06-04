using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}
