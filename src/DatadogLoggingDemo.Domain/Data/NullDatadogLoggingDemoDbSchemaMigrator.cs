using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DatadogLoggingDemo.Data;

/* This is used if database provider does't define
 * IDatadogLoggingDemoDbSchemaMigrator implementation.
 */
public class NullDatadogLoggingDemoDbSchemaMigrator : IDatadogLoggingDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
