using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wxd.Models;
using wxd.Models.Requests;

namespace wxd.Parsers
{
    public class TafParser : Parser
    {
        private DecodeTafRequest _request;

        public TafParser(IDecodeRequest request)
        {
            _request = (DecodeTafRequest)request;
        }

        public override IWeatherProduct Parse()
        {
            throw new NotImplementedException();
        }
    }
}
