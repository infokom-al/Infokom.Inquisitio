using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Inquisitio.Domain
{


	public abstract class Entity
	{

	}

	public abstract class Entity<TKey> : Entity where TKey : notnull, IEquatable<TKey>
	{
		public TKey Id { get; }
	}
}
