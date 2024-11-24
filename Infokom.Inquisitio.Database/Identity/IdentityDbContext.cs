using Infokom.Inquisitio.Database.Extensions;
using Infokom.Inquisitio.Domain.Entities.Identity;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Inquisitio.Database.Identity
{
	public class IdentityDbContext : IdentityDbContext<User, Role, int, User.Claim, Grant, User.Login, Role.Claim, User.Token>
	{
		public IdentityDbContext()
		{

		}

		public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
		{

		}

		

		protected override void OnModelCreating(ModelBuilder model)
		{
			base.OnModelCreating(model);

			model.ApplyIdentityConfigurations();
		}
	}
}
