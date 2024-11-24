using Microsoft.AspNetCore.Identity;

namespace Infokom.Inquisitio.Domain.Entities.Identity
{
	public class Role : IdentityRole<int>
	{
		public class Claim : IdentityRoleClaim<int>
		{

		}
	}
}
