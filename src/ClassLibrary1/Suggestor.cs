using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class Suggestor : ISuggestor
    {
        public Suggestor(ITeamScraper scraper, ITradeEngine engine)
        {
            _scraper = scraper;
            _engine = engine;
        }
        private readonly ITeamScraper _scraper;
        private readonly ITradeEngine _engine;

        public TradeSuggestion SuggestTrade(Uri teamUri)
        {
            var team1 = new Team(teamUri);
            var team2Uri = new Uri(Regex.Replace(teamUri.ToString(), @"teamId=(\d*)", "teamId=1"));
            var team2 = new Team(team2Uri);
            var result = new TradeSuggestion(teamUri, team2Uri, _engine.Tweaks);

            _scraper.Populate(result.Team1);
            _scraper.Populate(result.Team2);

            result.TradesToTry.AddRange(_engine.ProposeTrades(result));

            return result;

        }
    }
}
