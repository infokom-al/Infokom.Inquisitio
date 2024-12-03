using System.Linq.Expressions;

namespace Infokom.Inquisitio.Application.FIlters.Registry
{
	public interface ISpecification<TEntity> where TEntity : class
	{




		
		public Expression<Func<TEntity, bool>> ToExpression();

		public bool IsSatisfiedBy(TEntity entity) => this.ToExpression().Compile().Invoke(entity);
	}
}
