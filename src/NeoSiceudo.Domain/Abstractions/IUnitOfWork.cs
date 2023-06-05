﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSiceudo.Domain.Abstractions;

public interface IUnitOfWork
{
	Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}