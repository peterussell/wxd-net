using System;
using WXD.Models;
using WXD.Parsers;

namespace WXD.Factories
{
    public class ParserFactory
    {
        public static Parser CreateParser(WeatherProductType productType)
        {
            switch(productType)
            {
                case WeatherProductType.METAR:
                    return new MetarParser();

                case WeatherProductType.TAF:
                    return new TafParser();

                case WeatherProductType.SIGMET:
                    return new SigmetParser();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
