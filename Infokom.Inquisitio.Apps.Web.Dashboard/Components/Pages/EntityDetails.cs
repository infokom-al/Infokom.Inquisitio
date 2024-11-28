using BlazorBootstrap;

using Infokom.Inquisitio.Domain;
using Infokom.Inquisitio.Domain.Entities.Registry;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;
using System.Numerics;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infokom.Inquisitio.Apps.Web.Dashboard.Components.Pages
{
	public abstract class EntityDetails<TContext, TKey, TEntity> : Page<TContext> where TContext : DbContext where TKey : notnull where TEntity : class
	{

		[Parameter]
		public TKey Id { get; set; }

		protected TEntity Entity { get; set; }

		protected override async Task OnInitializedAsync()
		{
			PreloadService.Show();

			try
			{
				this.Entity = await this.Context.FindAsync<TEntity>(this.Id);
			}
			catch (Exception ex)
			{
				Error(ex);
			}

			PreloadService.Hide();
		}

	}
}
