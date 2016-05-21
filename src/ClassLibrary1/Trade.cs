using System;
using System.Collections.Generic;
using System.Linq;

namespace Szalapski.FantasyTrades.Lib
{
    public class Trade
    {
        public Trade(IEnumerable<TradablePlayer> giveUp, IEnumerable<TradablePlayer> receive, EngineTweaks tweaks)
        {
            GiveUp = giveUp.ToArray();
            Receive = receive.ToArray();
            _tweaks = tweaks;
        }
        private EngineTweaks _tweaks;

        public Trade(TradablePlayer giveUp, TradablePlayer receive, EngineTweaks tweaks) : this(new[] { giveUp }, new[] { receive }, tweaks) { }
        
        public TradablePlayer[] GiveUp { get; private set; }
        public TradablePlayer[] Receive { get; private set; }
        

        public decimal Favorability => Receive.Sum(tp => tp.Rating) - GiveUp.Sum(tp => tp.Rating);
        public decimal Fairness => 100.0M - Math.Abs(Favorability);
        public bool AllScrubs => Receive.All(tp => tp.Rating <= _tweaks.ScrubThreshold);
    }
}