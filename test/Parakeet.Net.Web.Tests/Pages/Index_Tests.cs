using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Parakeet.Net.Pages;

public class Index_Tests : NetWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
