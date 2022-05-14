using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Gamers8POC.Pages;

public class Index_Tests : Gamers8POCWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
