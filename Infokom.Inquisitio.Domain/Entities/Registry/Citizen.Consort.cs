using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public partial class Citizen
	{
		public partial class Consort
		{
			[Key, ForeignKey(nameof(Owner))]
			public long OwnerId { get; set; }

			[Required, StringLength(64)]
			public string GivenName { get; set; }

			[Required, StringLength(64)]
			public string FamilyName { get; set; }

			[StringLength(64)]
			public string MaidenName { get; set; }

			public virtual Citizen Owner { get; set; }
		}

		public virtual ICollection<Consort> Consorts { get; set; } = new HashSet<Consort>();
	}



}

