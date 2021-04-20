using System.Linq;
using WindPowerSystemV3.Repositories.Models;

namespace WindPowerSystemV3.Repositories
{
	public class DbSeeder
	{
		public static void Seed(Context dbContext)
		{
			if (!dbContext.TurbineTypes.Any()) CreateTurbineTypes(dbContext);
		}

		private static void CreateTurbineTypes(Context dbContext)
		{
			var typeV = new TurbineType() { Model = "V39/600", Capacity = 600 };
			var typeSG = new TurbineType() { Model = "SG 2.1-114", Capacity = 1140 };
			var typeN = new TurbineType() { Model = "N43", Capacity = 800 };
			var typeE = new TurbineType() { Model = "E-44", Capacity = 900 };

			// Insert turbine types into the Database
			dbContext.TurbineTypes.AddRange(typeV, typeSG, typeN, typeE);

			dbContext.SaveChanges();
		}
	}
}
