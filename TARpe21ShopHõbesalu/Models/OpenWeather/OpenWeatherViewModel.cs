namespace TARpe21ShopHõbesalu.Models.OpenWeather
{
    public class OpenWeatherViewModel
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public int AirPressure { get; set; }
        public int AirHumidity { get; set; }
        public string Main { get; set; }
        public double WindSpeed { get; set; }
    }
}