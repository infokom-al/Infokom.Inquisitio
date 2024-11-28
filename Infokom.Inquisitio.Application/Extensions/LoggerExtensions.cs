using Microsoft.Extensions.Logging;

namespace Infokom.Inquisitio.Application.Extensions
{
	public static class LoggerExtensions
	{
		public static void Log<TException>(this ILogger source, TException exception) where TException : Exception
		{
			source.Log(LogLevel.Error, exception, exception.Message);
		}
	}
}
