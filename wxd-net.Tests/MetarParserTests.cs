using wxd.Models;
using wxd.Models.Requests;
using wxd.Parsers;
using Xunit;

namespace wxd_net.Tests
{
    public class MetarParserTests
    {
        [Fact]
        public void TestCreatesCorrectTypeOfResponse()
        {
            // Arrange
            var req = new DecodeMetarRequest() {
                Metar = "METAR 170430Z AUTO 16002KT 20KM NCD 08/02 Q1027"
            };
            var parser = new MetarParser();

            // Act
            var res = parser.Parse(req);

            // Assert
            Assert.Equal(WeatherProductType.METAR, res.Type);
        }

        [Fact]
        public void TestParseHeaderStripsMetarText()
        {
            // Arrange
            var input = "METAR 170430Z AUTO 16002KT 20KM NCD 08/02 Q1027";
            var expected = "170430Z AUTO 16002KT 20KM NCD 08/02 Q1027";
            var parser = new MetarParser();
            var metar = new Metar(input);

            // Act
            var res = parser.ParseHeader(input, ref metar);

            // Assert
            Assert.Equal(expected, res);
        }
    }
}
