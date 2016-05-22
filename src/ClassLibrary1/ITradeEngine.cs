using System.Collections.Generic;

namespace Szalapski.FantasyTrades.Lib
{
    public interface ITradeEngine
    {
        IEnumerable<Trade> ProposeTrades(TradeSuggestion result);
        EngineTweaks Tweaks { get; }
    }
}