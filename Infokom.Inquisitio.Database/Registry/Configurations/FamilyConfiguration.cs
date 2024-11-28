using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Registry.Configurations
{
	internal class FamilyConfiguration : IEntityTypeConfiguration<Family>
	{
		public void Configure(EntityTypeBuilder<Family> entity)
		{
			entity.ToTable("Family", "Registry");

			entity.OwnsMany(x => x.Members, ownedEntity =>
			{
				ownedEntity.ToTable("Family.Member", "Registry")
					.WithOwner(y => y.Owner);

				ownedEntity.Navigation(y => y.IsA).AutoInclude();
			});
				
		}
	}
}
