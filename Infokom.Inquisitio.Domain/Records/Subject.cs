using Infokom.Inquisitio.Domain.Atomics;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Domain.Records
{
	public record Subject
	{
		public SubjectType Type { get; set; }

		[Required, StringLength(16)]
		public string Code { get; set; }

		[Required, StringLength(256)]
		public string Name { get; set; }
	}
}
