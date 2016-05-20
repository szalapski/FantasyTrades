using System.Collections.Generic;

namespace Szalapski.FantasyTrades.Lib
{
    public interface ITradeEngine
    {
        List<Trade> ProposeTrades(TradeSuggestion result);
    }
}