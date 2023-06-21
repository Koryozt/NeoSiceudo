using Microsoft.EntityFrameworkCore;

namespace NeoSiceudo.Persistence;

public sealed class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(
		DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}

	protected override void OnModelCreating(ModelBuilder mb)
	{
		mb.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
	}
}
