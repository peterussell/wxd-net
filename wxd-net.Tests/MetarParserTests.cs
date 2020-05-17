using System.Runtime.InteropServices.ComTypes;
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
            var req = new DecodeMetarRequest() { Metar = "METAR 170430Z AUTO 16002KT 20KM NCD 08/02 Q1027" };
            var parser = new MetarParser(req);
            // Act
            var res = parser.Parse();
            // Assert
            Assert.Equal(WeatherProductType.METAR, res.Type);
        }

        [Fact]
        public void TestMoveNextUpdatesParserIndex()
        {
            // Arrange
            var req = new DecodeMetarRequest() { Metar = "METAR 170430Z AUTO 16002KT 20KM NCD 08/02 Q1027" };
            var parser = new MetarParser(req);
            // Act
            parser.moveNext("METAR");
            // Assert
            Assert.Equal(6, parser.CurrentPosition);
            }
    }
}
