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

        public IEnumerable<Trade> ProposeTrades(TradeSuggestion suggestion)
        {
            var result = new List<Trade>();
            foreach (Player player1 in suggestion.Team1.Players)
            {
                decimal player1Rating = _rater.Rate(player1);
                foreach (Player player2 in suggestion.Team2.Players)
                {
                    decimal player2Rating = _rater.Rate(player2);

                    if (Math.Abs(player2Rating - player1Rating) <= 1.0M)
                    {
                        result.Add(new Trade(new TradablePlayer(player1.Name, player1Rating),
                            new TradablePlayer(player2.Name, player2Rating)));
                    } 
                }
            }

            return result.OrderByDescending(t => t.Receive.Sum(tp =>tp.Rating) - t.GiveUp.Sum(tp => tp.Rating));
        }
    }
}
