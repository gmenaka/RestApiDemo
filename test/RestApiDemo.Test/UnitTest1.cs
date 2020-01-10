using Xunit;
using RestApiDemo.Controllers;
using Microsoft.Extensions.Logging;

namespace RestApiDemo.Test
{
    public class UnitTest1
    {       
        
        WeatherForecastController controller = new WeatherForecastController(null);
         
        [Fact]
        public void GetWeatherForecast()
        {
            var forecasts = controller.Get();
            Assert.NotNull(forecasts);
        }
       

        [Fact]
        public void Test1()
        {

        }
    }
}
