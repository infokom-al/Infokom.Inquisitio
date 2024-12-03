using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum SubjectType : byte
	{
		/// <summary>
		/// Physical Person
		/// </summary>
		[Display(Name = "Fizik")]
		Physical = 1,

		/// <summary>
		/// Juridical Person
		/// </summary>
		[Display(Name = "Juridik")]
		Juridical = 2,
	}



}
