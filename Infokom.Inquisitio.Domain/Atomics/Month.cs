using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Infokom.Inquisitio.Domain.Atomics
{
	public enum Month : byte
	{
		[Display(Name = "Janar")]
		JAN = 1,

		[Display(Name = "Shkurt")]
		FEB = 2,

		[Display(Name = "Mars")]
		MAR = 3,

		[Display(Name = "Prill")]
		APR = 4,

		[Display(Name = "Maj")]
		MAY = 5,

		[Display(Name = "Qershor")]
		JUN = 6,
		 
		[Display(Name = "Korrik")]
		JUL = 7,

		[Display(Name = "Gusht")]
		AUG = 8,

		[Display(Name = "Shtator")]
		SEP = 9,

		[Display(Name = "Tetor")]
		OCT = 10,

		[Display(Name = "Nentor")]
		NOV = 11,

		[Display(Name = "Dhjetor")]
		DEC = 12
	}


}
