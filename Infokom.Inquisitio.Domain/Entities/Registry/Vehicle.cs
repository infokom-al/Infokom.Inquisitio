using System;
using System.Collections.Generic;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public partial class Vehicle : Entity<Guid>
	{

		public string Code { get; set; }

		public string Name { get; set; }

		public string Brand { get; set; }

		public string Model { get; set; }

		public string Color { get; set; }

		public string Plate { get; set; }

		public string OwnerType { get; set; }

		public string OwnerCode { get; set; }

		public string OwnerName { get; set; }
	}
}
