using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class DummyEngine : ITradeEngine
    {
        public IEnumerable<Trade> ProposeTrades(TradeSuggestion result)
        {
            var trade1 = new Trade(new TradablePlayer("Babe Ruth","OF", 50), new TradablePlayer("Cap Anson", "SP", 30), new EngineTweaks());
            var trade2 = new Trade(new TradablePlayer("Lou Gehrig", "1B", 40), new TradablePlayer("Wee Willie Keeler", "2B", 40), new EngineTweaks());
            return new List<Trade> { trade1, trade2 };

        }
    }
}
