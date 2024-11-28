using BlazorBootstrap;

using Elfie.Serialization;

using Infokom.Blazor.Bootstrap.Extensions;

using Microsoft.AspNetCore.Components;
using Infokom.Inquisitio.Application.Extensions;
using System;
using System.Linq.Expressions;

namespace Infokom.Inquisitio.Apps.Web.Dashboard.Components.Pages
{

	public abstract partial class Page : ComponentBase
	{
		//[Inject]
		protected ILogger Logger { get; set; }

		[Inject]
		protected PreloadService PreloadService { get; set; }

		[Inject]
		protected ToastService ToastService { get; set; }

		[Inject]
		protected ModalService ModalService { get; set; }

		[Inject]
		protected NavigationManager NavigationManager { get; set; }


		protected abstract string Title { get; }

		protected abstract string Excerpt { get; }



		protected void Error(string message, string subject)
		{
			this.Logger?.LogError("{0}: {1}", message, subject);
			this.ToastService?.ShowError(message, subject);
		}

		protected void Error<TException>(TException exception) where TException : Exception
		{
			this.Logger?.Log(exception);
			this.ToastService?.Show(exception);
		}
	}

	public abstract partial class Page<TContext> : Page
	{
		[Inject]
		protected TContext Context { get; set; }
	}

}
