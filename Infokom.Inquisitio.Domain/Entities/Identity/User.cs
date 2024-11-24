using Microsoft.AspNetCore.Identity;

namespace Infokom.Inquisitio.Domain.Entities.Identity
{
	public class User : IdentityUser<int>
	{
		public class Claim : IdentityUserClaim<int>
		{

		}

		public class Login : IdentityUserLogin<int>
		{

		}

		public class Token : IdentityUserToken<int>
		{

		}
	}
}
