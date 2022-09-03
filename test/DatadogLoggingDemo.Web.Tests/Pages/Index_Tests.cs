using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace DatadogLoggingDemo.Pages;

[Collection(DatadogLoggingDemoTestConsts.CollectionDefinitionName)]
public class Index_Tests : DatadogLoggingDemoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
