using Infokom.Inquisitio.Domain.Atomics;
using Infokom.Inquisitio.Domain.Records;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public class Vehicle : Entity<Guid>
	{
		[Required, StringLength(32)]
		public string Code { get; set; }

		[Required, StringLength(256)]
		public string Name { get; set; }

		[Required, StringLength(64)]
		public string Brand { get; set; }

		[Required, StringLength(64)]
		public string Model { get; set; }

		public Color Color { get; set; }

		[Required, StringLength(64)]
		public string Plate { get; set; }



		public Subject Owner { get; set; } = new Subject();
	}
}
