namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string _location;
        private readonly double _celsius;

        public WeatherReporter(string location, double celsius)
        {
            _location = location;
            _celsius = celsius;
        }

        public string DisplayWeather()
        {
            return $"I am in {_location} and it is {DisplayLocationWeather()}. {DisplayTemperatureWeather()}. The temperature in Fahrenheit is {ConvertCelsiusToFahrenheit(_celsius)}.";
        }

        private double ConvertCelsiusToFahrenheit(double _celsius)
        {
            return ((9.0 / 5.0) * _celsius + 32);
        }

        private string DisplayLocationWeather()
        {
            switch (_location)
            {
                case ("London"):
                    return "🌦";
                case ("California"):
                    return "🌅";
                case ("Cape Town"):
                    return "🌤";
                default:
                    return "🔆";
            }
        }

        private string DisplayTemperatureWeather()
        {
            const int HighTemp = 30;
            const int LowTemp = 10;

            switch (_celsius)
            {
                case (> HighTemp):
                    return "It's too hot 🥵!";
                case (< LowTemp):
                    return "It's too cold 🥶!";
                default:
                    return "Ahhh...it's just right 😊!";
            }
        }
    }
}

