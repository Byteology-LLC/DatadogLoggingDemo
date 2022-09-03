using DatadogLoggingDemo.MongoDB;
using Volo.Abp.Modularity;

namespace DatadogLoggingDemo;

[DependsOn(
    typeof(DatadogLoggingDemoMongoDbTestModule)
    )]
public class DatadogLoggingDemoDomainTestModule : AbpModule
{

}
