namespace WXD.Models
{
    public class Metar
    {
        public string Type { get; private set; }
        public Metar(string encodedMetar)
        {
            this.Type = encodedMetar;
        }
    }
}
