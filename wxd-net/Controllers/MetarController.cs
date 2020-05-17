using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WXD.Models;
using WXD.Models.Requests;
using WXD.Models.Responses;
using WXD.Parsers;

namespace WXD.Controllers
{
    [ApiController]
    [Route("decode/[controller]")]
    public class MetarController : ControllerBase
    {
        private readonly ILogger<MetarController> _logger;

        public MetarController(ILogger<MetarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<DecodeMetarResponse> Get([FromBody] DecodeMetarRequest request)
        {
            var parser = new MetarParser();
            Metar metar = (Metar)parser.Parse(request);
            return new DecodeMetarResponse(metar);
        }   
    }
}