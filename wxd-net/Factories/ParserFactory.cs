using System;
using wxd.Models;
using wxd.Models.Requests;
using wxd.Parsers;

namespace wxd.Factories
{
    public class ParserFactory
    {
        public static Parser CreateParser(IDecodeRequest request, WeatherProductType productType)
        {
            switch(productType)
            {
                case WeatherProductType.METAR:
                    return new MetarParser(request);

                case WeatherProductType.TAF:
                    return new TafParser(request);

                case WeatherProductType.SIGMET:
                    return new SigmetParser(request);

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
