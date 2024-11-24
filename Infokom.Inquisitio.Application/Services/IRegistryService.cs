using Infokom.Inquisitio.Application.FIlters.Registry;
using Infokom.Inquisitio.Domain.Entities.Registry;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Application.Services
{
	public interface IRegistryService : IService
	{
		public IQueryable<Citizen> Citizens { get; }

		public IQueryable<Family> Families { get; }

		public IQueryable<Vehicle> Vehicles { get; }


		static string IService.Name => "Registry";
	}
}
