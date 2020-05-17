using System.Collections.Generic;
using wxd.Models.Requests;

namespace wxd.Models
{
    public class Sigmet : IWeatherProduct
    {
        public WeatherProductType Type { get { return WeatherProductType.SIGMET; } }
        public string OriginalSigmet { get; set; }
        public Dictionary<string, object> Tokens { get; set; }

        public Sigmet(DecodeSigmetRequest request)
        {
            Tokens = new Dictionary<string, object>();
        }
    }
}
