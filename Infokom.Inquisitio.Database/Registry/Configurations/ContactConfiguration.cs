using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Registry.Configurations
{
	internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
	{
		public void Configure(EntityTypeBuilder<Contact> entity)
		{
			entity.ToTable("Contact", "Registry");

			entity.Property(x => x.Code).IsFixedLength();

			entity.Property(x => x.Phones).HasConversion(
				source => string.Join(",", source),
				target => target.Split(",", StringSplitOptions.TrimEntries)
			);

			entity.HasKey(e => e.Id);
		}
	}
}
