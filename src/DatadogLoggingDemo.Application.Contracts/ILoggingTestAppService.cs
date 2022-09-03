using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DatadogLoggingDemo
{
    public interface ILoggingTestAppService : IApplicationService
    {
        Task CreateWarningLogAsync(string message = "");
        Task CreateErrorLogAsync(string message = "");
        Task CreateCriticalLogAsync(string message = "");
        Task CreateTraceLogAsync(string message = "");
        Task CreateInfoLogAsync(string message = "");
        Task SimulateExceptionAsync();
    }
}
