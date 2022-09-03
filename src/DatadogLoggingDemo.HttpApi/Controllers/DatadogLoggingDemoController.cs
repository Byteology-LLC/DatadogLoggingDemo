using DatadogLoggingDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DatadogLoggingDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DatadogLoggingDemoController : AbpControllerBase
{
    protected DatadogLoggingDemoController()
    {
        LocalizationResource = typeof(DatadogLoggingDemoResource);
    }
}
