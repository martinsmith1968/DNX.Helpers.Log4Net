// Code generated by a Template
using System;
using log4net;

namespace DNX.Helpers.Log4Net
{
    /// <summary>
    /// Class LogExtensions for Info
    /// </summary>
    public static partial class LogExtensions
    {
        /// <summary>
        /// Writes a Info message, if Info is enabled
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="messageText">The messageText.</param>
        public static void InfoFunc(this ILog logger, Func<string> messageText)
        {
            if (logger.IsInfoEnabled)
            {
                logger.Info(messageText());
            }
        }

        /// <summary>
        /// Writes a Info message with Exception, if Info is enabled
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="exception">The exception.</param>
        public static void InfoFunc(this ILog logger, Func<string> messageText, Func<Exception> exception)
        {
            if (logger.IsInfoEnabled)
            {
                logger.Info(messageText(), exception());
            }
        }
	}
}