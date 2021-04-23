using Microsoft.EntityFrameworkCore;
using WindPowerSystemV3.Repositories.Models;

namespace WindPowerSystemV3.Repositories
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{
			//Disable automigration
			Database.Migrate();
		}

		// DB sets
		public DbSet<TurbineType> TurbineTypes { get; set; }
		public DbSet<Turbine> Turbines { get; set; }
	}
}
