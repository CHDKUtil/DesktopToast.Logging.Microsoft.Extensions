using Microsoft.Extensions.Logging;

namespace DesktopToast.Logging.Microsoft.Extensions
{
	/// <summary>
	/// Desktop Toast Microsoft.Extensions.Logging Adapter
	/// </summary>
	public class LoggerAdapter : ILogger
    {
		private global::Microsoft.Extensions.Logging.ILogger Logger { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LoggerAdapter"/> class.
		/// </summary>
		/// <param name="loggerFactory">Logger factory.</param>
		public LoggerAdapter(ILoggerFactory loggerFactory)
		{
			Logger = loggerFactory.CreateLogger<ToastManager>();
		}

		/// <inheritdoc/>
		public void Log(LogLevel level, object obj)
		{
			Logger.Log(GetLogLevel(level), default(EventId), obj, null, null);
		}

		/// <inheritdoc/>
		public void Log(LogLevel level, string str)
		{
			Logger.Log(GetLogLevel(level), default(EventId), str, null, null);
		}

		/// <inheritdoc/>
		public void Log(LogLevel level, string format, params object[] args)
		{
			string str = string.Format(format, args);
			Logger.Log(GetLogLevel(level), default(EventId), str, null, null);
		}

		private static global::Microsoft.Extensions.Logging.LogLevel GetLogLevel(LogLevel level)
		{
			return (global::Microsoft.Extensions.Logging.LogLevel)level;
		}
	}
}
