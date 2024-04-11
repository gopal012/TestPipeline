using Microsoft.Extensions.Logging.Abstractions;
using TestPipeline.Controllers;

namespace unitTest1
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void ShouldReturnAListOfValues()
        {
            // Arrange
            var logger = new NullLogger<WeatherForecastController>();
            var service = new WeatherForecastController(logger);

            // Act
            var result = service.Get();

            // Assert
            Assert.NotNull(result);
        }
    }
}