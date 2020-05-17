using System.Collections.Generic;

namespace wxd.Models
{
    public class Metar : IWeatherProduct
    {
        public WeatherProductType Type { get { return WeatherProductType.METAR; } }
        public string OriginalMetar { get; set; }
        public Dictionary<string, object> Tokens { get; set; }

        public Metar()
        {
            Tokens = new Dictionary<string, object>();
        }

        // TODO: move to base class (convert IWeatherProduct to abstract)
        public void AddToken(string key, object value)
        {
            Tokens.Add(key, value);
        }
    }
}