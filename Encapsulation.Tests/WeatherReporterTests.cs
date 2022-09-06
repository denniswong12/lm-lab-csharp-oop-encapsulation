namespace Encapsulation.Tests;

public class WeatherReporterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Given_Location_Available_In_Switch_Cases_Should_Return_Corresponding_Icons_And_Temperature()
    {
        var WeatherReporterLondon = new WeatherReporter("London", 7);
        WeatherReporterLondon.DisplayWeather().Should().Be($"I am in London and it is 🌦. It's too cold 🥶!. The temperature in Fahrenheit is 44.6.");

        var WeatherReporterCapeTown = new WeatherReporter("Cape Town", 35);
        WeatherReporterCapeTown.DisplayWeather().Should().Be($"I am in Cape Town and it is 🌤. It's too hot 🥵!. The temperature in Fahrenheit is 95.");
    }

    [Test]
    public void Given_Location_And_Temperature_Out_Of_The_Cases_In_Switch_Should_Return_Default_Icons_And_Default_Temperature()
    {
        var WeatherReporterHK = new WeatherReporter("Hong Kong", 25);
        WeatherReporterHK.DisplayWeather().Should().Be($"I am in Hong Kong and it is 🔆. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 77.");

        var WeatherReporterCambridge = new WeatherReporter("Cambridge", 18);
        WeatherReporterCambridge.DisplayWeather().Should().Be($"I am in Cambridge and it is 🔆. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 64.4.");
    }

    [Test]
    public void Given_Empty_Location_Should_Return_Default_Icons_And_Default_Temperature()
    {
        var WeatherReporterEmpty = new WeatherReporter("", 18);
        WeatherReporterEmpty.DisplayWeather().Should().Be($"I am in  and it is 🔆. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 64.4.");
    }
}