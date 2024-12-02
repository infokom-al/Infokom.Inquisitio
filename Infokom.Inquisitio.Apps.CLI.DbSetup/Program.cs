using Infokom.Inquisitio.Database.Identity;
using Infokom.Inquisitio.Database.Registry;
using Microsoft.EntityFrameworkCore;

namespace Infokom.Inquisitio.Apps.CLI.DbSetup
{
	internal class Program
	{
		static void Main(string[] args)
		{

			using (var dbContext = new IdentityDbContext())
			{
				var sql = dbContext.Database.GenerateCreateScript();

				dbContext.Database.ExecuteSqlRaw(sql);
			}

			using (var dbContext = new RegistryDbContext())
			{
				var sql = dbContext.Database.GenerateCreateScript();

				dbContext.Database.ExecuteSqlRaw(sql);
			}
		}
	}
}
