using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV3.DTOs;
using WindPowerSystemV3.Repositories.Interfaces;
using WindPowerSystemV3.Repositories.Models;
using WindPowerSystemV3.Services.Interfaces;

namespace WindPowerSystemV3.Services
{
	public class TurbineService : BaseService, ITurbineService
	{
		private readonly ITurbineRepository turbineRepository;

		public TurbineService(ITurbineRepository turbineRepository)
		{
			this.turbineRepository = turbineRepository;
		}

		public IEnumerable<TurbineDto> GetAllTurbines()
		{
			var turbines = turbineRepository.GetAll();

			var turbineDtoList = new List<TurbineDto>();

			turbines.ToList().ForEach(turbine =>
			{
				turbineDtoList.Add(Mapper.Map<Turbine, TurbineDto>(turbine));
			});

			return turbineDtoList;
		}

		public TurbineDto GetTurbineById(int id)
		{
			var turbine = turbineRepository.FindById(id);
			if (turbine == null) throw new Exception("Turbine wasn't found");

			return Mapper.Map<Turbine, TurbineDto>(turbine);
		}

		public void UpdateTurbine(int id, TurbineDto dto)
		{
			var turbine = turbineRepository.FindById(id);
			if (turbine == null) throw new Exception("Turbine wasn't found");

			if (dto.SerialNum != null)
				turbine.SerialNum = dto.SerialNum;

			if (dto.ProdMW != 0)
				turbine.ProdMW = dto.ProdMW;

			turbineRepository.Update(turbine);
		}

		public TurbineDto Create(TurbineDto dto)
		{
			var entityTurbine = Mapper.Map<TurbineDto, Turbine>(dto);

			turbineRepository.Create(entityTurbine);

			return Mapper.Map<Turbine, TurbineDto>(turbineRepository.FindById(entityTurbine.Id));
		}
	}
}
