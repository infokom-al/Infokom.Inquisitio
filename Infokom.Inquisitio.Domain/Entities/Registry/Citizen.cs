using Infokom.Inquisitio.Domain.Atomics;

using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public partial class Citizen
	{

		[Key]
		public long Id { get; set; }

		[StringLength(10, MinimumLength = 10)]
		public string Code { get; set; }

		[Required, MaxLength(64)]
		public string Register { get; set; }

		[Required, MaxLength(256)]
		public string Address { get; set; }

		[Required, MaxLength(64)]
		public string GivenName { get; set; }

		[Required, MaxLength(64)]
		public string FamilyName { get; set; }

		[Required, MaxLength(64)]
		public string FatherName { get; set; }

		[Required, MaxLength(64)]
		public string MotherName { get; set; }

		public Gender Gender { get; set; }

		public DateOnly BirthDate { get; set; }

		[Required, MaxLength(64)]
		public string BirthPlace { get; set; }

		[Required, MaxLength(64)]
		public string District { get; set; }

		[Required, MaxLength(64)]
		public string Nationality { get; set; }

		public Marital Marital { get; set; }
	}
}

