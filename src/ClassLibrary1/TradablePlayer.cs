namespace Szalapski.FantasyTrades.Lib
{
    public class TradablePlayer : Player
    {
        public TradablePlayer(string name, decimal rating) : base(name) {
            Rating = rating;
        }

        public decimal Rating { get; }
    }
}
