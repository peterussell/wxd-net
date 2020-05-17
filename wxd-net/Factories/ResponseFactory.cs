using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wxd.Models;
using wxd.Models.Responses;

namespace wxd.Factories
{
    public class ResponseFactory
    {
        public static IDecodeResponse CreateResponse(IWeatherProduct weatherProduct)
        {
            switch (weatherProduct.Type)
            {
                case WeatherProductType.METAR:
                    return new DecodeMetarResponse((Metar)weatherProduct);

                case WeatherProductType.TAF:
                    return new DecodeTafResponse((Taf)weatherProduct);

                case WeatherProductType.SIGMET:
                    return new DecodeSigmetResponse((Sigmet)weatherProduct);

                default:
                    throw new NotSupportedException("Invalid weather product type");
            }
        }
    }
}
