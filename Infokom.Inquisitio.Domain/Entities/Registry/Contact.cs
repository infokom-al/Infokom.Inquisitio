using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public class Contact : Entity<long>
	{
		[Required, StringLength(10, MinimumLength = 10)]
		public string Code { get; set; }

		[Required, StringLength(256)]
		public string Name { get; set; }

		[Required, StringLength(64)]
		public string GivenName { get; set; }


		[Required, StringLength(64)]
		public string FamilyName { get; set; }

		[Required, StringLength(64)]
		public string FatherName { get; set; }

		public DateOnly BirthDate { get; set; }


		public string[] Phones { get; set; } = new string[0];

	}
}
