using System;
using System.Collections.Generic;
using wxd.Models;
using wxd.Models.Requests;

namespace wxd.Parsers
{
    public class MetarParser : Parser
    {
        private DecodeMetarRequest _request;
        public int CurrentPosition = 0;
        public Metar Metar { get; set; }

        public MetarParser(IDecodeRequest request)
        {
            _request = (DecodeMetarRequest)request;
        }

        public override IWeatherProduct Parse()
        {
            Metar = new Metar();
            var metarText = _request.Metar.ToUpper();
            Metar.OriginalMetar = metarText;

            // Parsers add fields to the Metar and advance parserIndex to the next token
            ParseHeader(metarText);
            ParseDateTime(metarText);
            ParseAutomated(metarText);
            ParseWindVector(metarText);
            ParseVisibility(metarText);
            ParseCloudLayers(metarText);
            ParseTempAndDewpoint(metarText);
            ParseQnh(metarText);

            return Metar;
        }

        // ---- PARSERS ----
        public void ParseHeader(string input)
        {
            var token = peekToken(input);
            if (token.Equals("METAR")) {
                // Ignore
                moveNext(token);
            }
        }

        public void ParseDateTime(string input)
        {
            var token = peekToken(input);
            Metar.AddToken("issued_at", token);
            moveNext(token);
        }

        public void ParseAutomated(string input)
        {
            var token = peekToken(input);
            if (token.Equals("AUTO"))
            {
                Metar.AddToken("auto", true);
                moveNext(token);
            } else
            {
                Metar.AddToken("auto", false);
            }
        }

        public void ParseWindVector(string input)
        {
            var token = peekToken(input);
            Metar.AddToken("wind", token);
            moveNext(token);
        }

        public void ParseVisibility(string input)
        {
            var token = peekToken(input);
            Metar.AddToken("visibility", token);
            moveNext(token);
        }

        public void ParseCloudLayers(string input)
        {
            var layers = new List<string>();
            var token = peekToken(input);
            layers.Add(token);
            Metar.AddToken("cloud", layers);
            moveNext(token);
        }

        public void ParseTempAndDewpoint(string input)
        {
            var token = peekToken(input);
            var parts = token.Split('/');
            Metar.AddToken("temp", parts[0]);
            Metar.AddToken("dewpoint", parts[1]);
            moveNext(token);
        }
        public void ParseQnh(string input)
        {
            var token = peekToken(input);
            Metar.AddToken("qnh", token.Replace("Q", string.Empty));
            moveNext(token);
        }


        // ---- HELPERS ----
        public string peekToken(string input)
        {
            var nextSpaceIndex = input.Substring(CurrentPosition).IndexOf(' ');
            var token = "";
            if (nextSpaceIndex > 0)
            {
                token = input.Substring(CurrentPosition, nextSpaceIndex);
            } else
            {
                token = input.Substring(CurrentPosition);
            }
            return token;
        }

        public void moveNext(string currentToken)
        {
            CurrentPosition += currentToken.Length + 1;
        }
    }
}
