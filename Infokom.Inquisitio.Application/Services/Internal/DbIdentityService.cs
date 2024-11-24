using Infokom.Inquisitio.Database.Identity;
using Infokom.Inquisitio.Domain.Entities.Identity;

namespace Infokom.Inquisitio.Application.Services.Internal
{
	internal class DbIdentityService : IIdentityService
	{
		private IdentityDbContext _dbContext;

		public DbIdentityService(IdentityDbContext dbContext)
		{
			_dbContext = dbContext;
		}


		public IQueryable<User> Users => _dbContext.Users.AsQueryable();

		public IQueryable<Role> Roles => _dbContext.Roles.AsQueryable();
	}
}
