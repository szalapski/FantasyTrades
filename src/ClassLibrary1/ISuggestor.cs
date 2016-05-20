using System;

namespace Szalapski.FantasyTrades.Lib
{
    public interface ISuggestor
    {
        TradeSuggestion SuggestTrade(Uri teamUri);
    }
}