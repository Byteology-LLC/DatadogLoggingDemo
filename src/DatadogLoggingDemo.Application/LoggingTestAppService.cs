using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Users;

namespace DatadogLoggingDemo
{
    public class LoggingTestAppService : DatadogLoggingDemoAppService, ILoggingTestAppService
    {
        private readonly ILogger<LoggingTestAppService> _logger;
        private readonly ICurrentUser _currentUser;

        public LoggingTestAppService(ILogger<LoggingTestAppService> logger, ICurrentUser currentUser)
        {
            _logger = logger;
            _currentUser = currentUser;
        }

        /// <summary>
        /// Writes a Critical-level log to the stream
        /// </summary>
        /// <param name="message">Optional: A message to include in the log.</param>
        /// <returns></returns>
        public async Task CreateCriticalLogAsync(string message = "")
        {
           if(!string.IsNullOrWhiteSpace(message))
            {
                _logger.LogCritical(message);
            }
            else
            {
                var timestamp = DateTime.Now;
                var user = _currentUser.IsAuthenticated ? _currentUser.Name : "Unauthenticated User";
                _logger.LogCritical("Critical Test Log at {Timestamp} by {User}", timestamp, user);
            }
        }

        /// <summary>
        /// Writes a Error-level log to the stream
        /// </summary>
        /// <param name="message">Optional: A message to include in the log.</param>
        /// <returns></returns>
        public async Task CreateErrorLogAsync(string message = "")
        {
            _logger.LogError(string.IsNullOrWhiteSpace(message) ? "Error Test Log" : message);
        }

        /// <summary>
        /// Writes a Information-level log to the stream
        /// </summary>
        /// <param name="message">Optional: A message to include in the log.</param>
        /// <returns></returns>
        public async Task CreateInfoLogAsync(string message = "")
        {
            _logger.LogInformation(string.IsNullOrWhiteSpace(message) ? "Info Test Log" : message);
        }

        /// <summary>
        /// Writes a Trace-level log to the stream
        /// </summary>
        /// <param name="message">Optional: A message to include in the log.</param>
        /// <returns></returns>
        public async Task CreateTraceLogAsync(string message = "")
        {
            _logger.LogTrace(string.IsNullOrWhiteSpace(message) ? "Trace Test Log" : message);
        }

        /// <summary>
        /// Writes a Warning-level log to the stream
        /// </summary>
        /// <param name="message">Optional: A message to include in the log.</param>
        /// <returns></returns>
        public async Task CreateWarningLogAsync(string message = "")
        {

            _logger.LogWarning(string.IsNullOrWhiteSpace(message) ? "Warning Test Log": message);
        }

        /// <summary>
        /// Throws a UserFriendlyException to demonstrate the logging on ABP handled exceptions.
        /// </summary>
        /// <returns></returns>
        public async Task SimulateExceptionAsync()
        {
            throw new UserFriendlyException("This is a test exception");
        }
    }
}
