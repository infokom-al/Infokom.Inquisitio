using Infokom.Inquisitio.Domain.Atomics;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public partial class Family
	{
		public partial class Member
		{
			[Key, ForeignKey(nameof(IsA))]
			public long Id { get; set; }

			[ForeignKey(nameof(Owner))]
			public long OwnerId { get; set; }

			public Kinship Role { get; set; }

			public Family Owner { get; set; }

			public virtual Citizen IsA { get; set; }
		}

		public virtual ICollection<Member> Members { get; set; } = new HashSet<Member>();

	}
}

