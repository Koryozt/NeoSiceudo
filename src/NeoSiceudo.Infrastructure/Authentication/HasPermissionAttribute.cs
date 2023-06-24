﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NeoSiceudo.Domain.Enumerators;

namespace NeoSiceudo.Infrastructure.Authentication;

public class HasPermissionAttribute : AuthorizeAttribute
{
	public HasPermissionAttribute(Permissions permission)
		: base(policy: permission.ToString()!)
	{

	}
}
