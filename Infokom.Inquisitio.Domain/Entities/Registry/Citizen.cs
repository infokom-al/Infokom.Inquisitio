using Infokom.Inquisitio.Domain.Atomics;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public class Citizen
	{
		[Key]
		public long Id { get; set; }

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

		[ForeignKey(nameof(Marital))]
		public Marital Marital { get; set; }

		[Required, MaxLength(64)]
		public string Nationality { get; set; }

		public Consort Consort { get; set; } = new Consort();
	}



	public record Consort
	{
		[MaxLength(64)]
		public string GivenName { get; set; }

		[MaxLength(64)]
		public string FamilyName { get; set; }

		[MaxLength(64)]
		public string MaidenName { get; set; }
	}
}

