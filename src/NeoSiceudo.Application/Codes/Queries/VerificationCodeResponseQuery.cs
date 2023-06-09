﻿using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.VerificationCode;

namespace NeoSiceudo.Application.Codes.Queries;

public sealed record VerificationCodeResponseQuery(
	Guid Id,
	bool Taken,
	Combination Combination,
	User User);
