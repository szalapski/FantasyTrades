using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class Suggestor : ISuggestor
    {
        public Suggestor()
        {

        }

        public TradeSuggestion SuggestTrade(Uri teamUri)
        {
            var team1 = new Team(teamUri);
            var team2Uri = new Uri(Regex.Replace(teamUri.ToString(), @"teamId=(\d*)", "teamId=1"));
            var team2 = new Team(team2Uri);
            return new TradeSuggestion(teamUri, team2Uri);
        }
    }
}
