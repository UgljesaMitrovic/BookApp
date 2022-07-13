using System;
using Xunit;
using System.Threading.Tasks;
using BookApp;

namespace BookApp.UnitTests
{
    public class ServiceTests
    {
        [Fact]
        public async Task GivenAValidUrl_GetSomeData_ReturnsSomeData333()
        {
            var service = new Service();

            var result = await service.GetData("https://api.actionnetwork.com/web/v1/books");

            Assert.True(result.Books.Count > 0);
        }
    }
}
