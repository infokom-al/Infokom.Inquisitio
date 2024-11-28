using BlazorBootstrap;

using Infokom.Blazor.Bootstrap.Extensions;
using Infokom.Inquisitio.Application.FIlters.Registry;

using Microsoft.EntityFrameworkCore;

namespace Infokom.Inquisitio.Apps.Web.Dashboard.Components.Pages
{
	public abstract class EntitySearch<TContext, TKey, TEntity, TFilter> : Page<TContext> 
		where TContext : DbContext
		where TKey : notnull 
		where TEntity : class
		where TFilter : IFilter<TEntity>, new()
	{
		protected TFilter Filter { get; set; } = new TFilter();

		protected IQueryable<TEntity> Query { get; set; }

		protected Grid<TEntity> Grid { get; set; }

		protected async Task Search()
		{
			this.PreloadService.Show();

			try
			{
				this.Query = this.Context.Set<TEntity>().AsQueryable();

				if (this.Filter != null)
					this.Query = this.Query.Where(this.Filter.ToExpression());

				await Grid.RefreshDataAsync();
			}
			catch (Exception ex)
			{
				this.ToastService.Notify(new ToastMessage(ToastType.Danger, "ERROR", ex.Message));
			}

			this.PreloadService.Hide();

		}


		protected async Task Clear()
		{
			this.PreloadService.Show();

			try
			{
				this.PreloadService.Show();

				this.Query = Enumerable.Empty<TEntity>().AsQueryable();

				await Grid.RefreshDataAsync();
			}
			catch (Exception ex)
			{
				this.ToastService.Notify(new ToastMessage(ToastType.Danger, "ERROR", ex.Message));
			}

			this.PreloadService.Hide();

		}
	}
}
