using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindPowerSystemV3.Services.Interfaces;

namespace WindPowerSystemV3.Services
{
	public class BaseService : IBaseService
	{
		public IMapper Mapper { get; set; }
	}
}
