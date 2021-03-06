// Code generated by a Template
using System;
using log4net;

namespace DNX.Helpers.Log4Net
{
    /// <summary>
    /// Class LogExtensions for Debug
    /// </summary>
    public static partial class LogExtensions
    {
        /// <summary>
        /// Writes a Debug message, if Debug is enabled
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="messageText">The messageText.</param>
        public static void DebugFunc(this ILog logger, Func<string> messageText)
        {
            if (logger.IsDebugEnabled)
            {
                logger.Debug(messageText());
            }
        }

        /// <summary>
        /// Writes a Debug message with Exception, if Debug is enabled
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="exception">The exception.</param>
        public static void DebugFunc(this ILog logger, Func<string> messageText, Func<Exception> exception)
        {
            if (logger.IsDebugEnabled)
            {
                logger.Debug(messageText(), exception());
            }
        }
	}
}
