using BlazorBootstrap;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infokom.Blazor.Bootstrap.Extensions
{
	public static class GridDataProviderRequestExtensions
	{
		public static async Task<GridDataProviderResult<TItem>> ApplyToAsync<TItem>(this GridDataProviderRequest<TItem> request, IQueryable<TItem> query)
		{
			var totalCount = 0;
			var data = Enumerable.Empty<TItem>();

			if (query != null)
			{

				//Filtering
				try
				{
					var expression = request.Filters?
						.Select(x => ExpressionExtensions.GetExpressionDelegate<TItem>(Expression.Parameter(typeof(TItem)), x))?
						.Aggregate((a, b) => a.And(b));

					if (expression != null)
					{
						query = query.Where(expression);
					}

					var orderBy = request.Sorting?.FirstOrDefault();
					if (orderBy != null)
					{
						var orderedQueryable = orderBy.SortDirection switch
						{
							SortDirection.None or
							SortDirection.Ascending => query.OrderBy(orderBy.SortKeySelector),
							SortDirection.Descending => query.OrderByDescending(orderBy.SortKeySelector),
							_ => throw new InvalidEnumArgumentException()
						};

						foreach (var thenBy in request.Sorting?.Skip(1))
						{
							orderedQueryable = orderBy.SortDirection switch
							{
								SortDirection.None or
								SortDirection.Ascending => orderedQueryable.ThenBy(orderBy.SortKeySelector),
								SortDirection.Descending => orderedQueryable.ThenByDescending(orderBy.SortKeySelector),
								_ => throw new InvalidEnumArgumentException()
							};
						}

						query = orderedQueryable;
					}

					totalCount = await query.CountAsync();

					if (request.PageNumber > 0 && request.PageSize > 0)
					{
						var takeCount = request.PageSize;
						if (takeCount > 0)
						{
							query = query.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize);
						}
					}

					data = await query.ToListAsync();
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine("Error trying to paginate. \n{0}\n{1}\n", ex.Message, ex.StackTrace);
				}
			}

			return new GridDataProviderResult<TItem>
			{
				TotalCount = totalCount,
				Data = data,
			};
		}

	}
}
