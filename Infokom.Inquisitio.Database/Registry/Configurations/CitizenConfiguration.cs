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

			entity.Property(x => x.Code).IsFixedLength();

			entity.OwnsMany(x => x.Consorts)
				.ToTable("Citizen.Consort", "Registry")
				.WithOwner(y => y.Owner);
		}

	}
}
