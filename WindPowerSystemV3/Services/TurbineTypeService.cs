using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV3.DTOs;
using WindPowerSystemV3.Repositories.Interfaces;
using WindPowerSystemV3.Repositories.Models;
using WindPowerSystemV3.Services.Interfaces;

namespace WindPowerSystemV3.Services
{
	public class TurbineTypeService : BaseService, ITurbineTypeService
	{
		private readonly ITurbineTypeRepository turbineTypeRepository;

		public TurbineTypeService(ITurbineTypeRepository turbineTypeRepository)
		{
			this.turbineTypeRepository = turbineTypeRepository;
		}

		public IEnumerable<TurbineTypeDto> GetAllTurbineTypes()
		{
			var turbineTypes = turbineTypeRepository.GetAll();

			var turbineTypeDtoList = new List<TurbineTypeDto>();

			turbineTypes.ToList().ForEach(turbineType =>
			{
				turbineTypeDtoList.Add(Mapper.Map<TurbineType, TurbineTypeDto>(turbineType));
			});

			return turbineTypeDtoList;
		}

		public TurbineTypeDto GetTurbineTypeById(int id)
		{
			var turbineType = turbineTypeRepository.FindById(id);
			if (turbineType == null) throw new Exception("TurbineType wasn't found");

			return Mapper.Map<TurbineType, TurbineTypeDto>(turbineType);
		}

		public void UpdateTurbineType(int id, TurbineTypeDto dto)
		{
			var turbineType = turbineTypeRepository.FindById(id);
			if (turbineType == null) throw new Exception("TurbineType wasn't found");

			if (dto.Model != null)
				turbineType.Model = dto.Model;

			if (dto.Capacity != 0)
				turbineType.Capacity = dto.Capacity;

			turbineTypeRepository.Update(turbineType);
		}

		public TurbineTypeDto Create(TurbineTypeDto dto)
		{
			var entityTurbineType = Mapper.Map<TurbineTypeDto, TurbineType>(dto);

			turbineTypeRepository.Create(entityTurbineType);

			return Mapper.Map<TurbineType, TurbineTypeDto>(turbineTypeRepository.FindById(entityTurbineType.Id));
		}
	}
}
