namespace WXD.Models.Requests
{
    public class DecodeMetarRequest : IDecodeRequest
    {
        public string Metar { get; set; }
    }
}
