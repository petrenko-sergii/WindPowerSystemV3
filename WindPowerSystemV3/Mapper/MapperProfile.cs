using AutoMapper;
using WindPowerSystemV3.DTOs;
using WindPowerSystemV3.Repositories.Models;

namespace WindPowerSystemV3.Mapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<TurbineType, TurbineTypeDto>()
				.ForMember(t => t.Model, opt => opt.MapFrom(expression => expression.Model))
				.ForMember(t => t.Capacity, opt => opt.MapFrom(expression => expression.Capacity))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Turbine, TurbineDto>()
				.ForMember(t => t.SerialNum, opt => opt.MapFrom(expression => expression.SerialNum))
				.ForMember(t => t.ProdMW, opt => opt.MapFrom(expression => expression.ProdMW))
				.ForMember(t => t.TurbineTypeId, opt => opt.MapFrom(expression => expression.TurbineTypeId))
				.IncludeAllDerived().ReverseMap();
		}
	}
}
