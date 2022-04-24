using System;
using Xunit;
using Moq;
using Shouldly;
using System.Linq;
using RoomBookingApp.Api.Controllers;
using Microsoft.Extensions.Logging;

namespace RoomBookingApp.Api.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Return_Forecast_Results()
        {
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            var result = controller.Get();

            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(1);
        }
    }
}
