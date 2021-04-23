using System.Collections.Generic;
using WindPowerSystemV3.DTOs;

namespace WindPowerSystemV3.Services.Interfaces
{
	public interface ITurbineService
	{
		IEnumerable<TurbineDto> GetAllTurbines();
		TurbineDto GetTurbineById(int id);
		TurbineDto Create(TurbineDto dto);
		void UpdateTurbine(int id, TurbineDto dto);
		//void Remove(int id);
	}
}
