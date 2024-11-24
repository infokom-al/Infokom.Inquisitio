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

			entity.Property(e => e.Brand).IsUnicode(false);
			entity.Property(e => e.Code).IsUnicode(false);
			entity.Property(e => e.Color).IsUnicode(false);
			entity.Property(e => e.Model).IsUnicode(false);
			entity.Property(e => e.Name).IsUnicode(false);
			entity.Property(e => e.OwnerCode)
				 .IsUnicode(false)
				 .HasColumnName("Owner.Code");
			entity.Property(e => e.OwnerName)
				 .IsUnicode(false)
				 .HasColumnName("Owner.Name");
			entity.Property(e => e.OwnerType)
				 .IsUnicode(false)
				 .HasColumnName("Owner.Type");
			entity.Property(e => e.Plate).IsUnicode(false);


			entity.HasKey(e => e.Id	);
		}
	}
}
