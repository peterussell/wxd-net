using WXD.Models.Requests;

namespace WXD.Models
{
    public class Sigmet : IWeatherProduct
    {
        public WeatherProductType Type
        {
            get { return WeatherProductType.SIGMET; }
        }
        public string OriginalSigmet { get; private set; }

        public Sigmet(DecodeSigmetRequest request)
        {
            this.OriginalSigmet = request.Sigmet;
        }
    }
}
