using WXD.Models.Requests;

namespace WXD.Models
{
    public class Taf : IWeatherProduct
    {
        public WeatherProductType Type
        {
            get { return WeatherProductType.TAF; }
        }
        public string OriginalTaf { get; private set; }

        public Taf(DecodeTafRequest request)
        {
            this.OriginalTaf = request.Taf;
        }
    }
}
