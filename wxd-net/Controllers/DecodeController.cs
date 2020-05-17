using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using wxd.Factories;
using wxd.Models;
using wxd.Models.Requests;
using wxd.Models.Responses;

namespace wxd.Controllers
{
    [ApiController]
    [Route("decode")]
    public class DecodeController : ControllerBase
    {
        private readonly ILogger<DecodeController> _logger;

        public DecodeController(ILogger<DecodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("metar")]
        public ActionResult<DecodeMetarResponse> Get([FromBody] DecodeMetarRequest request)
        {
            return (DecodeMetarResponse)HandleGetInternal(request, WeatherProductType.METAR);
        }

        [HttpGet]
        [Route("taf")]
        public ActionResult<DecodeTafResponse> Get([FromBody] DecodeTafRequest request)
        {
            return (DecodeTafResponse)HandleGetInternal(request, WeatherProductType.TAF);
        }

        [HttpGet]
        [Route("sigmet")]
        public ActionResult<DecodeSigmetResponse> Get([FromBody] DecodeSigmetRequest request)
        {
            return (DecodeSigmetResponse)HandleGetInternal(request, WeatherProductType.SIGMET);
        }

        private IDecodeResponse HandleGetInternal(IDecodeRequest request, WeatherProductType productType)
        {
            var parser = ParserFactory.CreateParser(productType);
            IWeatherProduct result = parser.Parse(request);
            return ResponseFactory.CreateResponse(result);
        }
    }
}