using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WXD.Models.Responses
{
    public class DecodeMetarResponse
    {
        [JsonPropertyName("original_metar")]
        public string OriginalMetar { get; set; }
        
        public DecodeMetarResponse(Metar metar)
        {
            this.OriginalMetar = metar.OriginalMetar;
        }
    }
}
