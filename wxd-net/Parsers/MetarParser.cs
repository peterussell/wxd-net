using wxd.Models;
using wxd.Models.Requests;

namespace wxd.Parsers
{
    public class MetarParser : Parser
    {
        private Metar _metar = null;

        public override IWeatherProduct Parse(IDecodeRequest request)
        {
            var text = ((DecodeMetarRequest)request).Metar.ToUpper();
            var metar = new Metar(text);

            // Each parser removes its section, adds it to the METAR,
            // and returns the remaining METAR text.
            text = this.ParseHeader(text, ref metar);


            return metar;
        }

        // Removes 'METAR ' from the start of the METAR
        public string ParseHeader(string text, ref Metar metar)
        {
            if (text.StartsWith("METAR ")) {
                text = text.Remove(0, "METAR ".Length);
            }
            return text;
        }
    }
}
