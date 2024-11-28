using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace Infokom.Inquisitio.Application.FIlters.Registry
{
	public record VehicleFilter : IFilter<Vehicle>
	{
		public string Plate { get; set; }


		public Expression<Func<Vehicle, bool>> ToExpression() => x =>
			EF.Functions.Like(x.Plate, "%" + (this.Plate ?? "") + "%");
	}
}
