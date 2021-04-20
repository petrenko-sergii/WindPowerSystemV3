using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindPowerSystemV3.DTOs;

namespace WindPowerSystemV3.Services.Interfaces
{
	public interface ITurbineTypeService
	{
		IEnumerable<TurbineTypeDto> GetAllTurbineTypes();
		TurbineTypeDto GetTurbineTypeById(int id);
		TurbineTypeDto Create(TurbineTypeDto dto);
		void UpdateTurbineType(int id, TurbineTypeDto dto);
		//void Remove(int id);
	}
}
