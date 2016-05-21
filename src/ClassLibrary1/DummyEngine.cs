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
            var trade1 = new Trade(new TradablePlayer("Babe Ruth",50), new TradablePlayer("Cap Anson", 30), new EngineTweaks());
            var trade2 = new Trade(new TradablePlayer("Lou Gehrig",40), new TradablePlayer("Wee Willie Keeler",40), new EngineTweaks());
            return new List<Trade> { trade1, trade2 };

        }
    }
}
