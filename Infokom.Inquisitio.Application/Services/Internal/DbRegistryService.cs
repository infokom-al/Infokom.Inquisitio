using Infokom.Inquisitio.Application.FIlters.Registry;
using Infokom.Inquisitio.Database.Registry;
using Infokom.Inquisitio.Domain;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Application.Services.Internal
{

	internal class DbRegistryService : IRegistryService
	{

		private readonly RegistryDbContext _dbContext;

		public DbRegistryService(RegistryDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IQueryable<Citizen> Citizens => _dbContext.Citizens.AsQueryable();

		public IQueryable<Family> Families => _dbContext.Families.AsQueryable();

		public IQueryable<Vehicle> Vehicles => _dbContext.Vehicles.AsQueryable();


		
	}
}
