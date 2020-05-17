using System;
using wxd.Models.Requests;

namespace wxd.Models
{
    public class Metar : IWeatherProduct
    {
        public WeatherProductType Type
        {
            get { return WeatherProductType.METAR; }
        }
        public string OriginalMetar { get; private set; }

        public Metar(string originalMetar)
        {
            this.OriginalMetar = originalMetar;
        }
    }
}
