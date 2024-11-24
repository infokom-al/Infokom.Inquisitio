using Infokom.Inquisitio.Domain.Entities.Identity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infokom.Inquisitio.Database.Identity.Configurations
{
	internal class UserConfiguration : IEntityTypeConfiguration<User>, IEntityTypeConfiguration<User.Claim>, IEntityTypeConfiguration<User.Login>, IEntityTypeConfiguration<User.Token>
	{
		public void Configure(EntityTypeBuilder<User> entity)
		{
			entity.ToTable("User", "Identity");
		}

		public void Configure(EntityTypeBuilder<User.Claim> entity)
		{
			entity.ToTable("User.Claim", "Identity");
		}

		public void Configure(EntityTypeBuilder<User.Login> entity)
		{
			entity.ToTable("User.Login", "Identity");
		}

		public void Configure(EntityTypeBuilder<User.Token> entity)
		{
			entity.ToTable("User.Token", "Identity");
		}
	}
}
