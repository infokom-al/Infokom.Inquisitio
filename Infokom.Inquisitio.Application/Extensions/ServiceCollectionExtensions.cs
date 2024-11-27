using Infokom.Inquisitio.Application.Services;
using Infokom.Inquisitio.Application.Services.Internal;
using Infokom.Inquisitio.Database.Identity;
using Infokom.Inquisitio.Database.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infokom.Inquisitio.Application.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration) 
		{
			services.AddDbContext<IdentityDbContext>(contextLifetime: ServiceLifetime.Singleton, optionsAction: x => x
				.UseSqlServer(configuration.GetConnectionString("Identity"))
				.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
			);
			services.AddSingleton<IIdentityService, DbIdentityService>();

			services.AddDbContext<RegistryDbContext>(contextLifetime: ServiceLifetime.Singleton, optionsAction: x => x
				.UseSqlServer(configuration.GetConnectionString("Registry"))
				.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
			);
			services.AddSingleton<IRegistryService, DbRegistryService>();

			return services;
		}
	}
}
