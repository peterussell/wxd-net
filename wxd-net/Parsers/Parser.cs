using WXD.Models;
using WXD.Models.Requests;

namespace WXD.Parsers
{
    public abstract class Parser
    {
        public abstract IWeatherProduct Parse(IDecodeRequest request);
    }
}
