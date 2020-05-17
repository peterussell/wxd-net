using WXD.Models;
using WXD.Models.Requests;

namespace WXD.Parsers
{
    public interface IParser
    {
        public IWeatherProduct Parse(DecodeMetarRequest request);
    }
}
