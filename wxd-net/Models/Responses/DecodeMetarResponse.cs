using System.Text.Json.Serialization;

namespace WXD.Models.Responses
{
    public class DecodeMetarResponse : IDecodeResponse
    {
        [JsonPropertyName("original_metar")]
        public string OriginalMetar { get; set; }
        
        public DecodeMetarResponse(Metar metar)
        {
            this.OriginalMetar = metar.OriginalMetar;
        }
    }
}
