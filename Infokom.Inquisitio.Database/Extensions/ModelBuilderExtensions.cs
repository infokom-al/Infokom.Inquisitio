using Infokom.Inquisitio.Database.Identity.Configurations;
using Infokom.Inquisitio.Domain.Entities.Identity;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Database.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static ModelBuilder ApplyIdentityConfigurations(this ModelBuilder source)
		{			
			source.ApplyConfiguration<User>(new UserConfiguration());
			source.ApplyConfiguration<User.Claim>(new UserConfiguration());
			source.ApplyConfiguration<User.Login>(new UserConfiguration());
			source.ApplyConfiguration<User.Token>(new UserConfiguration());

			source.ApplyConfiguration<Role>(new RoleConfiguration());
			source.ApplyConfiguration<Role.Claim>(new RoleConfiguration());

			source.ApplyConfiguration<Grant>(new GrantConfiguration());

			return source;
		}
	}
}
