using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class Engine : ITradeEngine
    {
        public Engine(IPlayerRater rater)
        {
            _rater = rater;
        }
        IPlayerRater _rater;

        public List<Trade> ProposeTrades(TradeSuggestion suggestion)
        {
            var result = new List<Trade>();
            foreach (Player player1 in suggestion.Team1.Players)
            {
                foreach (Player player2 in suggestion.Team2.Players)
                {
                    if (Math.Abs(_rater.Rate(player1) - _rater.Rate(player2)) < 1.0M)
                    {
                        result.Add(new Trade(player1, player2));
                    } 
                }
            }

            return result;
        }
    }
}
