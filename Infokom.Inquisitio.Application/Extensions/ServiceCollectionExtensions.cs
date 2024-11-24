using Infokom.Inquisitio.Application.Services;
using Infokom.Inquisitio.Application.Services.Internal;
using Infokom.Inquisitio.Database.Identity;
using Infokom.Inquisitio.Database.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Application.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration) 
		{
			services.AddDbContext<IdentityDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("Identity")), ServiceLifetime.Singleton);
			services.AddDbContext<RegistryDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("Registry")), ServiceLifetime.Singleton);
			
			services.AddSingleton<IIdentityService, DbIdentityService>();
			services.AddSingleton<IRegistryService, DbRegistryService>();

			return services;
		}
	}
}
