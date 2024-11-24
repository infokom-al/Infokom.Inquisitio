using Infokom.Inquisitio.Domain.Entities.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public class Family
	{


		public partial class Member
		{
			[Key, ForeignKey(nameof(IsA))]
			public long Id { get; set; }

			public long OwnerId { get; set; }

			public byte Role { get; set; }

			public virtual Citizen IsA { get; set; }
		}

		//public partial class Member : Citizen
		//{
		//	public long OwnerId { get; set; }

		//	public byte Role { get; set; }
		//}


		public long Id { get; set; }

		public virtual ICollection<Member> Members { get; set; } = new HashSet<Member>();
	}
}

