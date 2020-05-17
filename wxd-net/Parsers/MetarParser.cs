﻿using WXD.Models;
using WXD.Models.Requests;

namespace WXD.Parsers
{
    public class MetarParser : Parser
    {
        public override IWeatherProduct Parse(IDecodeRequest request)
        {
            return new Metar((DecodeMetarRequest)request);
        }
    }
}
