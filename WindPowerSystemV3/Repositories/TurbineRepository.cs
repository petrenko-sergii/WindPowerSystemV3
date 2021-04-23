using WindPowerSystemV3.Repositories.Interfaces;
using WindPowerSystemV3.Repositories.Models;

namespace WindPowerSystemV3.Repositories
{
	public class TurbineRepository : BaseRepository<Turbine>, ITurbineRepository
	{
		public TurbineRepository(Context dbContext) : base(dbContext)
		{
		}
	}
}
