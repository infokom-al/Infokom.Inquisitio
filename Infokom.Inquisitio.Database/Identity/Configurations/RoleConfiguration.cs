using Infokom.Inquisitio.Domain.Entities.Identity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Identity.Configurations
{
	internal class RoleConfiguration : IEntityTypeConfiguration<Role>, IEntityTypeConfiguration<Role.Claim>
	{
		public void Configure(EntityTypeBuilder<Role> entity)
		{
			entity.ToTable("Role", "Identity");
		}

		public void Configure(EntityTypeBuilder<Role.Claim> entity)
		{
			entity.ToTable("Role.Claim", "Identity");
		}
	}
}
