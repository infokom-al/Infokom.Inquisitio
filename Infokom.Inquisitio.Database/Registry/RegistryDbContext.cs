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

		public virtual DbSet<Contact> Contacts { get; set; }

		public virtual DbSet<Salary>  Salaries { get; set; }


		protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
		{
			configuration.Properties<Gender>().HaveConversion<EnumToNumberConverter<Gender, byte>>();
			configuration.Properties<Marital>().HaveConversion<EnumToNumberConverter<Marital, byte>>();
			configuration.Properties<Kinship>().HaveConversion<EnumToNumberConverter<Kinship, byte>>();
			configuration.Properties<Color>().HaveConversion<EnumToNumberConverter<Color, int>>();
			configuration.Properties<SubjectType>().HaveConversion<EnumToNumberConverter<SubjectType, byte>>();
			configuration.Properties<EnterpriseType>().HaveConversion<EnumToNumberConverter<EnterpriseType, byte>>();
		}

		protected override void OnModelCreating(ModelBuilder model)
		{
			model.HasDefaultSchema("Registry");
			
			model.ApplyConfiguration(new CitizensConfiguration());
			model.ApplyConfiguration(new FamilyConfiguration());
			model.ApplyConfiguration(new VehicleConfiguration());
			model.ApplyConfiguration(new ContactConfiguration());
			model.ApplyConfiguration(new SalaryConfiguration());
		}
	}

}
