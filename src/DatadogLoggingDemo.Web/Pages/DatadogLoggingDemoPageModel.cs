using DatadogLoggingDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DatadogLoggingDemo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class DatadogLoggingDemoPageModel : AbpPageModel
{
    protected DatadogLoggingDemoPageModel()
    {
        LocalizationResourceType = typeof(DatadogLoggingDemoResource);
    }
}
