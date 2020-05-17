using System;
using wxd.Models;
using wxd.Models.Requests;

namespace wxd.Parsers
{
    public class SigmetParser : Parser
    {
        private DecodeSigmetRequest _request;
        public SigmetParser(IDecodeRequest request)
        {
            _request = (DecodeSigmetRequest)request;
        }
        public override IWeatherProduct Parse()
        {
            throw new NotImplementedException();
        }
    }
}
