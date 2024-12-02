namespace Infokom.Domain
{
	public interface IEntity<T> : IEquatable<T>, IComparable<T> where T : class, IEntity<T>
	{

	}
}
