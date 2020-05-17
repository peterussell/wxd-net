using System.Text.Json.Serialization;

namespace WXD.Models.Responses
{
    public class DecodeTafResponse : IDecodeResponse
    {
        [JsonPropertyName("original_taf")]
        public string OriginalTaf { get; set; }
        
        public DecodeTafResponse(Taf taf)
        {
            this.OriginalTaf = taf.OriginalTaf;
        }
    }
}
