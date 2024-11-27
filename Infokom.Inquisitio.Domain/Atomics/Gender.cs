using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum Gender : byte
	{
		[Display(Name = "Mashkull")]
		Male = 1,

		[Display(Name = "Femer")]
		Female = 2
	}
}
