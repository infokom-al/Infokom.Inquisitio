using BlazorBootstrap;

using Microsoft.Extensions.Logging;



namespace Infokom.Blazor.Bootstrap.Extensions
{
	public static class ToastServiceExtensions
	{
		public static EventId ToEventId(this ToastType source) => new EventId((int)source, source.ToString());


		public static void Show(this ToastService source, ToastType type = default, string message = null, string subject = null) => source.Notify(new ToastMessage(type, subject, message)
		{
			AutoHide = type == ToastType.Danger,
			IconName = type switch
			{
				ToastType.Info => IconName.Info,
				ToastType.Success => IconName.CheckCircle,
				ToastType.Warning => IconName.ExclamationTriangle,
				ToastType.Danger => IconName.ExclamationCircle,
				_ => default,
			},
			HelpText = $"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}",
		});




		public static void ShowInfo(this ToastService source, string message = null, string subject = null) => source.Show(ToastType.Info, message, subject);
		public static void ShowSuccess(this ToastService source, string message = null, string subject = null) => source.Show(ToastType.Success, message, subject);
		public static void ShowWarning(this ToastService source, string message = null, string subject = null) => source.Show(ToastType.Warning, message, subject);
		public static void ShowError(this ToastService source, string message = null, string subject = null) => source.Show(ToastType.Danger, message, subject);




		public static void Show<TException>(this ToastService source, TException exception) where TException : Exception => source.ShowError(exception.Message, typeof(TException).Name);














		public static void Show(this ToastService source, Notification notification)
		{
			source.Notify(new ToastMessage()
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

	
}
