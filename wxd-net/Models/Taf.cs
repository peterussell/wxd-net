using System.Collections.Generic;
using wxd.Models.Requests;

namespace wxd.Models
{
    public class Taf : IWeatherProduct
    {
        public WeatherProductType Type { get { return WeatherProductType.TAF; } }
        public string OriginalTaf { get; set; }
        public Dictionary<string, object> Tokens { get; set; }

        public Taf()
        {
            Tokens = new Dictionary<string, object>();
        }
    }
}
