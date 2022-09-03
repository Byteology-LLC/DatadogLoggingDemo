using System;
using System.Collections.Generic;
using System.Text;
using DatadogLoggingDemo.Localization;
using Volo.Abp.Application.Services;

namespace DatadogLoggingDemo;

/* Inherit your application services from this class.
 */
public abstract class DatadogLoggingDemoAppService : ApplicationService
{
    protected DatadogLoggingDemoAppService()
    {
        LocalizationResource = typeof(DatadogLoggingDemoResource);
    }
}
