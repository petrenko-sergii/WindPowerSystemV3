using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV3.DTOs;
using WindPowerSystemV3.Services.Interfaces;

namespace WindPowerSystemV3.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TurbineController : Controller
    {
		private readonly ITurbineService turbineService;

		public TurbineController(ITurbineService turbineService)
		{
			this.turbineService = turbineService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<TurbineDto>> Get()
		{
			var turbineDtos = turbineService.GetAllTurbines();
			return turbineDtos.ToList();
		}

		[HttpGet("{id}")]
		public ActionResult<TurbineDto> Get(int id)
		{
			return turbineService.GetTurbineById(id);
		}

		[HttpPut("{id}")]
		public void Put(int id, TurbineDto dto)
		{
			turbineService.UpdateTurbine(id, dto);
		}

		[HttpPost]
		public ActionResult<TurbineDto> Post(TurbineDto dto)
		{
			return turbineService.Create(dto);
		}
	}
}