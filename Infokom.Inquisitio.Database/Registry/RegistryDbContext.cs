using Infokom.Inquisitio.Database.Registry.Configurations;
using Infokom.Inquisitio.Domain.Atomics;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using System.Linq.Expressions;
using System.Reflection;

namespace Infokom.Inquisitio.Database.Registry
{

	public class RegistryDbContext : BaseDbContext
	{
		public RegistryDbContext()
		{
		}

		public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options)
		{
		}

		public virtual DbSet<Citizen> Citizens { get; set; }

		public virtual DbSet<Family> Families { get; set; }

		public virtual DbSet<Vehicle> Vehicles { get; set; }


		protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
		{
			configuration.Properties<Gender>().HaveConversion<EnumToNumberConverter<Gender, byte>>();
			configuration.Properties<Marital>().HaveConversion<EnumToNumberConverter<Marital, byte>>();
		}

		protected override void OnModelCreating(ModelBuilder model)
		{
			model.HasDefaultSchema("Registry");
			
			model.ApplyConfiguration(new CitizensConfiguration());
			model.ApplyConfiguration(new FamilyConfiguration());
			model.ApplyConfiguration(new VehicleConfiguration());
		}
	}

}
