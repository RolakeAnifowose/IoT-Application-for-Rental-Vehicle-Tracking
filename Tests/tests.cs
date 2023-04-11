using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWebApp.Tests
{
    [TestClass]
    public class MyWebAppTests
    {
        [TestMethod]
        public async Task IndexPageTest()
        {
            // Arrange
            var client = new HttpClient();

            // Act
            var response = await client.GetAsync("https://geolocationwebapp.azurewebsites.net");

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
