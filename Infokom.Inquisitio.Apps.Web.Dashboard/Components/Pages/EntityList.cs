using BlazorBootstrap;

using Infokom.Blazor.Bootstrap.Extensions;
using Infokom.Inquisitio.Application.FIlters.Registry;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace Infokom.Inquisitio.Apps.Web.Dashboard.Components.Pages
{
	public abstract class EntityList<TContext, TEntity> : Page<TContext> where TContext : DbContext where TEntity : class
	{
		
		protected abstract Expression<Func<TEntity, bool>> Filter { get; }
	}



}
