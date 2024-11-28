using Infokom.Inquisitio.Domain.Atomics;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Application.Models.Registry
{




	public class FamilyInfo : HashSet<FamilyInfo.MemberInfo>
	{
		public record MemberInfo
		{
			public Kinship Role { get; set; }

			public string Code { get; set; }

			public string FullName { get; set; }

			public string FatherName { get; set; }

			public string MotherName { get; set; }

			public Gender Gender { get; set; }

			public DateOnly BirthDate { get; set; }

			public string BirthPlace { get; set; }

			public Marital Marital { get; set; }

			public string Nationality { get; set; }
		}



		public long Id { get; init; }

		public IEnumerable<MemberInfo> Members { get; init; } = Enumerable.Empty<MemberInfo>();
	}
}
