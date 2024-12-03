using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Registry.Configurations
{
	internal class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
	{
		public void Configure(EntityTypeBuilder<Vehicle> entity)
		{
			entity.ToTable("Vehicle", "Registry");

			entity.OwnsOne(x => x.Owner, ownedType =>
			{
				ownedType.Property(y => y.Type).HasColumnName("Owner.Type");
				ownedType.Property(y => y.Code).HasColumnName("Owner.Code");
				ownedType.Property(y => y.Name).HasColumnName("Owner.Name");
			});

			entity.HasKey(e => e.Id	);
		}
	}
}
