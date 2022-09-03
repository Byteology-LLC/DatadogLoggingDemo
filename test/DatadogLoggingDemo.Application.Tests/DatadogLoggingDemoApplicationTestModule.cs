using Volo.Abp.Modularity;

namespace DatadogLoggingDemo;

[DependsOn(
    typeof(DatadogLoggingDemoApplicationModule),
    typeof(DatadogLoggingDemoDomainTestModule)
    )]
public class DatadogLoggingDemoApplicationTestModule : AbpModule
{

}
