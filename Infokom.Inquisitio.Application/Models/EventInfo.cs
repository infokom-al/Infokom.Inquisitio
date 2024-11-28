using Infokom.Inquisitio.Application.Extensions;

using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Application.Models
{

	public enum EventType : byte
	{
		[Display(Name = "INFO")]
		INFO = 2,
		
		[Display(Name = "KUJDES")]
		WARNING = 3,

		[Display(Name = "GABIM")]
		ERROR = 4,
	}

	public record EventInfo<TType> where TType : Enum
	{
		public EventType Type { get; }

		public string Title { get; set; }

		public string Summary { get; set; }
	}
}
