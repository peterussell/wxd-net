using System;
using WXD.Models.Requests;

namespace WXD.Models
{
    public class Metar : IWeatherProduct
    {
        public WeatherProductType Type
        {
            get { return WeatherProductType.METAR; }
        }
        public string OriginalMetar { get; private set; }

        public Metar(DecodeMetarRequest request)
        {
            this.OriginalMetar = request.Metar;
        }
    }
}
