using System.Diagnostics;
using log4net;

namespace DNX.Helpers.Log4Net
{
    /// <summary>
    /// Class LogManagerExtensions.
    /// </summary>
    public static class LogManagerExtensions
    {
        /// <summary>
        /// Gets the default logger.
        /// </summary>
        /// <returns>ILog.</returns>
        public static ILog GetDefaultLogger()
        {
            return LogManager.GetLogger(string.Empty);
        }

        /// <summary>
        /// Gets the logger for an object
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>ILog.</returns>
        public static ILog GetLoggerFor(object parent)
        {
            return parent == null
                ? GetDefaultLogger()
                : LogManager.GetLogger(parent.GetType());
        }

        /// <summary>
        /// Gets the logger for where it's currently running (owner)
        /// </summary>
        /// <returns>ILog.</returns>
        public static ILog GetMyLogger()
        {
            var trace = new StackTrace();
            var frame = trace.GetFrame(1);
            var caller = frame == null ? null : frame.GetMethod();

            return caller == null
                ? GetDefaultLogger()
                : LogManager.GetLogger(caller.DeclaringType);
        }

        /// <summary>
        /// Gets a logger for the type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>ILog.</returns>
        public static ILog GetLogger<T>()
        {
            return LogManager.GetLogger(typeof(T));
        }
    }
}
