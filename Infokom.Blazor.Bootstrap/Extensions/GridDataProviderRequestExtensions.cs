using BlazorBootstrap;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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



	
	public class Notifier : ToastService
	{
		public void Notify(Notification notification)
		{
			this.Notify(new ToastMessage()
			{
				AutoHide = notification.NotificationType != Notification.Type.ERROR,
				Type = notification.NotificationType switch
				{
					Notification.Type.INFO => ToastType.Info,
					Notification.Type.WARNING => ToastType.Warning,
					Notification.Type.ERROR => ToastType.Danger,
					_ => default,
				},
				IconName = notification.NotificationType switch
				{
					Notification.Type.INFO => IconName.InfoCircle,
					Notification.Type.WARNING => IconName.ExclamationTriangle,
					Notification.Type.ERROR => IconName.ExclamationCircle,
					_ => default,
				},
				Title = notification.Subject,
				Message = notification.Message,
				HelpText = notification.Created.ToString("dd.MM.yyyy HH:mm:ss"),
			});
		}
	}

	public sealed record Notification
	{
		public enum Type
		{
			INFO = 2,
			WARNING = 3,
			ERROR = 4,
		}

		public Notification(Type type, string subject, string message)
		{
			this.NotificationType = type;
			this.Subject = subject;
			this.Message = message;
		}

		public DateTimeOffset Created { get; }

		public Type NotificationType { get; }

		public string Subject { get; }

		public string Message { get; }



		public static Notification Info(string message) => new(Type.INFO, null, message);
		public static Notification Info(string subject, string message) => new(Type.INFO, subject, message);
		public static Notification Warning(string message) => new(Type.WARNING, null, message);
		public static Notification Warning(string subject, string message) => new(Type.WARNING, subject, message);
		public static Notification Error(string message) => new(Type.ERROR, null, message);
		public static Notification Error(string subject, string message) => new(Type.ERROR, subject, message);
	}

	
}
