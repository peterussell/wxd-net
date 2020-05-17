using WXD.Models;
using WXD.Models.Requests;

namespace WXD.Parsers
{
    public class MetarParser : IParser
    {
        public IWeatherProduct Parse(DecodeMetarRequest request)
        {
            return new Metar(request);
        }
    }
}
