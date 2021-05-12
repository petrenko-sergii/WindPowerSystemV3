using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV3.DTOs;
using WindPowerSystemV3.Services.Interfaces;

namespace WindPowerSystemV3.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TurbineTypeController : ControllerBase
	{
		private readonly ITurbineTypeService turbineTypeService;

		public TurbineTypeController(ITurbineTypeService turbineTypeService)
		{
			this.turbineTypeService = turbineTypeService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<TurbineTypeDto>> Get()
		{
			var turbineTypeDtos = turbineTypeService.GetAllTurbineTypes();
			return turbineTypeDtos.ToList();
		}

		[HttpGet("{id}")]
		public ActionResult<TurbineTypeDto> Get(int id)
		{
			return turbineTypeService.GetTurbineTypeById(id);
		}

		[HttpPut("{id}")]
		public void Put(int id, TurbineTypeDto dto)
		{
			turbineTypeService.UpdateTurbineType(id, dto);
		}

		[HttpPost]
		public ActionResult<TurbineTypeDto> Post(TurbineTypeDto dto)
		{
			return turbineTypeService.Create(dto);
		}
	}
}