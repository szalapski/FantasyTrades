using System;

namespace Szalapski.FantasyTrades.Lib
{
    public class TradeSuggestion
    {
        public TradeSuggestion(Uri teamUri, Uri team2Uri)
        {
           this.TeamUri = teamUri;
           this.Team2Uri = team2Uri;
        }

        public Uri TeamUri { get; private set; }
        public Uri Team2Uri { get; private set; }


        public String Foo { get; private set; } = "bar";
    }
}