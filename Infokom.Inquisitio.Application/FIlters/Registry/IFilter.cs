using System.Linq.Expressions;

namespace Infokom.Inquisitio.Application.FIlters.Registry
{
	public interface IFilter<T>
	{





		public Expression<Func<T, bool>> ToExpression();
	}
}
