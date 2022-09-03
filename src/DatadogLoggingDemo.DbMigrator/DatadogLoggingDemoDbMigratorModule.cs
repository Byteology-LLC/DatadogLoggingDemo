using DatadogLoggingDemo.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DatadogLoggingDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DatadogLoggingDemoMongoDbModule),
    typeof(DatadogLoggingDemoApplicationContractsModule)
    )]
public class DatadogLoggingDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
