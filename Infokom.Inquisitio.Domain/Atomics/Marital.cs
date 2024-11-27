using System.ComponentModel.DataAnnotations;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum Marital : byte
	{
		None = 0,

		/// <summary>
		/// Celibate
		/// </summary>
		[Display(Name = "Beqar/e")]
		Single = 1,

		/// <summary>
		/// Married
		/// </summary>
		[Display(Name = "Martuar")]
		Married = 2,

		/// <summary>
		/// Separated
		/// </summary>
		[Display(Name = "Ndare")]
		Separated = 3,

		/// <summary>
		/// Divorced
		/// </summary>
		[Display(Name = "Divorcuar")]
		Divorced = 4,

		/// <summary>
		/// Widowed
		/// </summary>
		[Display(Name = "I/E Ve")]
		Widowed = 5
	}
}
