using Infokom.Inquisitio.Domain;
using Infokom.Inquisitio.Domain.Atomics;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infokom.Inquisitio.Database
{
	public abstract class BaseDbContext : DbContext
	{
		public BaseDbContext()
		{

		}

		public BaseDbContext(DbContextOptions options) : base(options) 
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer("Data Source=(local);Initial Catalog=Infokom.Inquisitio;Integrated Security=SSPI;Encrypt=False;MultipleActiveResultSets=true;");
			}
		}

		protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
		{
			configuration.Properties<Day>().HaveConversion<EnumToStringConverter<Day>>().AreUnicode(false).HaveMaxLength(3).AreFixedLength();
			configuration.Properties<Month>().HaveConversion<EnumToStringConverter<Month>>().AreUnicode(false).HaveMaxLength(3).AreFixedLength();
			configuration.Properties<Gender>().HaveConversion<EnumToStringConverter<Gender>>().AreUnicode(false).HaveMaxLength(1).AreFixedLength();
			configuration.Properties<Marital>().HaveConversion<EnumToStringConverter<Marital>>().AreUnicode(false).HaveMaxLength(1).AreFixedLength();
		}


		
	}
}
