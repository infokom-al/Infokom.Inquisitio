using Infokom.Inquisitio.Domain.Atomics;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Infokom.Inquisitio.Application.FIlters.Registry
{
	public record VehicleSpecification : ISpecification<Vehicle>
	{
		public string Brand { get; set; }

		public string Model { get; set; }

		public Color? Color { get; set; }

		public string Plate { get; set; }

		public string Owner { get; set; }

		public Expression<Func<Vehicle, bool>> ToExpression()
		{
			return x =>
			EF.Functions.Like(x.Brand, "%" + (this.Brand ?? "") + "%") &&
			EF.Functions.Like(x.Model, "%" + (this.Model ?? "") + "%") &&
			!(this.Color.HasValue && x.Color != this.Color) &&
			(EF.Functions.Like(x.Owner.Code, "%" + (this.Owner ?? "") + "%") || EF.Functions.Like(x.Owner.Name, "%" + (this.Owner ?? "") + "%")) &&
			EF.Functions.Like(x.Plate, "%" + (this.Plate ?? "") + "%");
		}
	}



	public record ContactSpecification : ISpecification<Contact>
	{
		public string GivenName { get; set; }

		public string FamilyName { get; set; }

		public string FatherName { get; set; }

		public DateOnly? BirthDate { get; set; }

		public Expression<Func<Contact, bool>> ToExpression() => x =>
			EF.Functions.Like(x.GivenName, (this.GivenName ?? "") + "%") &&
			EF.Functions.Like(x.FamilyName,  (this.FamilyName ?? "") + "%") &&
			EF.Functions.Like(x.FatherName, (this.FatherName ?? "") + "%") &&
			(!this.BirthDate.HasValue || EF.Functions.DateDiffDay(x.BirthDate, this.BirthDate) == 0);
	}
}
