using Infokom.Inquisitio.Domain.Entities.Identity;

namespace Infokom.Inquisitio.Application.Services
{
	public interface IIdentityService : IService
	{
		public IQueryable<User> Users { get; }


		public IQueryable<Role> Roles { get; }





		static string IService.Name => "Identity";
	}
}
