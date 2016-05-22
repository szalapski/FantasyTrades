using System;
using System.Collections.Generic;
using System.Linq;

namespace Szalapski.FantasyTrades.Lib
{
    public class Engine : ITradeEngine
    {
        public Engine(IPlayerRater rater)
        {
            _rater = rater;
        }
        IPlayerRater _rater;

        public Engine(IPlayerRater rater, EngineTweaks tweaks) : this(rater)
        {
            Tweaks = tweaks;
        }

        public EngineTweaks Tweaks { get; } = new EngineTweaks();

        private IEnumerable<Trade> Reorder(IList<Trade> trades){
            return trades
                .OrderByDescending(trade => Tweaks.FavorBiasedTrades ? trade.Favorability : trade.Fairness)
                .ThenByDescending (trade => trade.Receive.Sum(tp => tp.Rating))
                ;
        }

        public IEnumerable<Trade> ProposeTrades(TradeSuggestion suggestion)
        {
            var result = new List<Trade>();
            foreach (Player player1 in suggestion.Team1.Players)
            {
                decimal player1Rating = _rater.Rate(player1);
                foreach (Player player2 in suggestion.Team2.Players)
                {
                    decimal player2Rating = _rater.Rate(player2);
                    if (!Tweaks.AllowScrubs && player2Rating <= Tweaks.ScrubThreshold) continue;
                    if (!Tweaks.AllowNegativeTrades && player2Rating < player1Rating) continue;

                    if (Math.Abs(player2Rating - player1Rating) <= 1.0M)
                    {
                        result.Add(new Trade(
                            new TradablePlayer(player1, player1Rating),
                            new TradablePlayer(player2, player2Rating),
                            Tweaks));
                    } 
                }
            }

            return Reorder(result);
        }
    }
}
