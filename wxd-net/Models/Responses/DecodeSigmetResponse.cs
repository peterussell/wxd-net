using System.Text.Json.Serialization;

namespace WXD.Models.Responses
{
    public class DecodeSigmetResponse : IDecodeResponse
    {
        [JsonPropertyName("original_sigmet")]
        public string OriginalSigmet { get; set; }
        
        public DecodeSigmetResponse(Sigmet sigmet)
        {
            this.OriginalSigmet = sigmet.OriginalSigmet;
        }
    }
}
