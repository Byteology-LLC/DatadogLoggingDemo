using Volo.Abp.Settings;

namespace DatadogLoggingDemo.Settings;

public class DatadogLoggingDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DatadogLoggingDemoSettings.MySetting1));
    }
}
