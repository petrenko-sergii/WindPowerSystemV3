using System.Linq;
using Autofac;
using Module = Autofac.Module;
using System.Reflection;
using WindPowerSystemV3.Services;
using WindPowerSystemV3.Services.Interfaces;

namespace WindPowerSystemV3.DI
{
	public class DefaultDIModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			//Registration All repositories 
			builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.Where(t => t.Name.EndsWith("Repository"))
				.AsImplementedInterfaces();

			//Registration Base Functionality
			builder.RegisterType<BaseService>().As<IBaseService>();

			//Registration Services
			builder.RegisterType<TurbineTypeService>().As<ITurbineTypeService>().PropertiesAutowired();
			builder.RegisterType<TurbineService>().As<ITurbineService>().PropertiesAutowired();
		}
	}
}
