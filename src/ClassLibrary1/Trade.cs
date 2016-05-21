using System.Collections.Generic;
using System.Linq;

namespace Szalapski.FantasyTrades.Lib
{
    public class Trade
    {
        public Trade(IEnumerable<TradablePlayer> giveUp, IEnumerable<TradablePlayer> receive)
        {
            GiveUp = giveUp.ToArray();
            Receive = receive.ToArray();
        }
        public Trade(TradablePlayer giveUp, TradablePlayer receive) : this(new[] { giveUp }, new[] { receive }) { }

        public TradablePlayer[] GiveUp { get; private set; }
        public TradablePlayer[] Receive { get; private set; }

        public decimal Fairness => Receive.Sum(tp => tp.Rating) - GiveUp.Sum(tp => tp.Rating);
        public bool AllScrubs => Receive.All(tp => tp.Rating <= 0);
    }
}