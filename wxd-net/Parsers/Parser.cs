using wxd.Models;
using wxd.Models.Requests;

namespace wxd.Parsers
{
    public abstract class Parser
    {
        public abstract IWeatherProduct Parse();
    }
}
