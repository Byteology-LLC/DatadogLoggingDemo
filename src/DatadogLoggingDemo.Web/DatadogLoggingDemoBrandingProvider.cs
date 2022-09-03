using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DatadogLoggingDemo.Web;

[Dependency(ReplaceServices = true)]
public class DatadogLoggingDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DatadogLoggingDemo";
}
