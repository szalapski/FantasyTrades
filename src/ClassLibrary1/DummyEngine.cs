using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class DummyEngine : ITradeEngine
    {
        public List<Trade> ProposeTrades(TradeSuggestion result)
        {
            var trade1 = new Trade(new Player("Babe Ruth"), new Player("Cap Anson"));
            var trade2 = new Trade(new Player("Lou Gehrig"), new Player("Wee Willie Keeler"));
            return new List<Trade> { trade1, trade2 };

        }
    }
}
