using Infokom.Inquisitio.Domain.Atomics;
using Infokom.Inquisitio.Domain.Records;

using System.ComponentModel.DataAnnotations.Schema;

namespace Infokom.Inquisitio.Domain.Entities.Registry
{
	public class Salary : Entity<Guid>
	{
		

		public EnterpriseInfo Employer { get; set; }


		public IndividualInfo Employee { get; set; }

		public string Role { get; set; }

		public int Year { get; set; }
		public Month Month { get; set; }
		public string Value { get; set; }
	}
}
