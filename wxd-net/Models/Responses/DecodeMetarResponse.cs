using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace wxd.Models.Responses
{
    public class DecodeMetarResponse : IDecodeResponse
    {
        [JsonPropertyName("original_metar")]
        public string OriginalMetar { get; set; }
        public Dictionary<string, object> Tokens { get; set; }
        
        public DecodeMetarResponse(Metar metar)
        {
            OriginalMetar = metar.OriginalMetar;
            Tokens = metar.Tokens;
        }
    }
}
