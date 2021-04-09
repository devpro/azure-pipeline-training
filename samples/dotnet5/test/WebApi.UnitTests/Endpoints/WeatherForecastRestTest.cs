using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Dotnet5Sample.WebApi.Dto;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Dotnet5Sample.WebApi.UnitTests.Endpoints
{
    public class WeatherForecastRestTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public WeatherForecastRestTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_WeatherForecastEndpointReturnSuccessAndListOfData()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetFromJsonAsync<List<WeatherForecastDto>>("/weather-forecast");

            // Assert
            response.Should().NotBeNullOrEmpty();
        }
    }
}
