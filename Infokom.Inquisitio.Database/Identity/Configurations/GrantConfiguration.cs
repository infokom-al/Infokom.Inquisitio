using Infokom.Inquisitio.Domain.Entities.Identity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Identity.Configurations
{
	internal class GrantConfiguration : IEntityTypeConfiguration<Grant>
	{
		public void Configure(EntityTypeBuilder<Grant> entity)
		{
			entity.ToTable("Grant", "Identity");
		}
	}
}
