using System.Threading.Tasks;

namespace DatadogLoggingDemo.Data;

public interface IDatadogLoggingDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
