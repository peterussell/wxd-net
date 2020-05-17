using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WXD.Models.Responses;

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
            var res = new DecodeMetarResponse();
            res.type = "METAR";
            return res;
        }   
    }
}