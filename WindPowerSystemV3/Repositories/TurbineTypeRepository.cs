using WindPowerSystemV3.Repositories.Interfaces;
using WindPowerSystemV3.Repositories.Models;

namespace WindPowerSystemV3.Repositories
{
	public class TurbineTypeRepository : BaseRepository<TurbineType>, ITurbineTypeRepository
	{
		public TurbineTypeRepository(Context dbContext) : base(dbContext)
		{
		}
	}
}
