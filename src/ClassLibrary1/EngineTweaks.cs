namespace Szalapski.FantasyTrades.Lib
{
    public class EngineTweaks
    {
        public decimal FairnessTolerance { get; set; } = 1.0M;

        /// <summary>
        /// True: biased to favor team 1.  False: biased to favor "fair trades",
        /// </summary>
        public bool FavorBiasedTrades { get; set; } = true;

        public bool AllowNegativeTrades { get; set; } = false;

        /// <summary>
        /// True: biased to favor biggest needs.  False: biased to favor overall value.
        /// </summary>

        public bool FavorNeeds { get; set; } = false;
        
        /// <summary>
        /// False: exclude trades for all scrubs (players with ratings at or below ScrubThreshold)
        /// </summary>
        public bool AllowScrubs { get; set; } = false;

        public decimal ScrubThreshold { get; set; } = 1.0M;
    }
}