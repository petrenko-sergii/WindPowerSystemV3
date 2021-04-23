using System;
using System.Linq;
using WindPowerSystemV3.Repositories.Models;

namespace WindPowerSystemV3.Repositories
{
	public class DbSeeder
	{
		public static void Seed(Context dbContext)
		{
			if (!dbContext.TurbineTypes.Any()) CreateTurbineTypes(dbContext);
			if (!dbContext.Turbines.Any()) CreateTurbines(dbContext);
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

		private static void CreateTurbines(Context dbContext)
		{
			var turbineV = new Turbine() { SerialNum = "V52/850/2014-dk/kol-863", ProdMW = 850, TurbineTypeId = 1 };
			var turbineSG = new Turbine() { SerialNum = "SG2.1-114/2013-dk/kol-605", ProdMW = 1140, TurbineTypeId = 2 };
			var turbineN = new Turbine() { SerialNum = "N43/2011-dk/kol-536", ProdMW = 800, TurbineTypeId = 3 };
			var turbineE = new Turbine() { SerialNum = "E-44/2016-dk/kol-221", ProdMW = 900, TurbineTypeId = 4 };

			// Insert turbines into the Database
			dbContext.Turbines.AddRange(turbineV, turbineSG, turbineN, turbineE);

			dbContext.SaveChanges();
		}
	}
}
