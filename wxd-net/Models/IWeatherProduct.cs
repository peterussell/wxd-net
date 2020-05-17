namespace wxd.Models
{
    public interface IWeatherProduct
    {
        WeatherProductType Type { get; }
    }

    public enum WeatherProductType
    {
        METAR,
        TAF,
        SIGMET
    }
}