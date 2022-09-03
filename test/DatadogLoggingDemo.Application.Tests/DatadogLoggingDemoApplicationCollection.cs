using DatadogLoggingDemo.MongoDB;
using Xunit;

namespace DatadogLoggingDemo;

[CollectionDefinition(DatadogLoggingDemoTestConsts.CollectionDefinitionName)]
public class DatadogLoggingDemoApplicationCollection : DatadogLoggingDemoMongoDbCollectionFixtureBase
{

}
