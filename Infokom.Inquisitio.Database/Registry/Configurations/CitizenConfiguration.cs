using Infokom.Inquisitio.Domain;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Database.Registry.Configurations
{
	internal class CitizensConfiguration : IEntityTypeConfiguration<Citizen>

	{

		public void Configure(EntityTypeBuilder<Citizen> entity)
		{
			entity.ToTable("Citizen", "Registry");

			entity.OwnsOne(x => x.Consort, ownedType =>
			{
				ownedType.Property(y => y.GivenName).HasColumnName("Consort.GivenName").HasMaxLength(64);
				ownedType.Property(y => y.FamilyName).HasColumnName("Consort.FamilyName").HasMaxLength(64);
				ownedType.Property(y => y.MaidenName).HasColumnName("Consort.MaidenName").HasMaxLength(64);
			});
		}


	}
}
