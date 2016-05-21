namespace Szalapski.FantasyTrades.Lib
{
    public class TradablePlayer : Player
    {
        public TradablePlayer(string name, string positions, decimal rating) : base(name, positions)
        {
            Rating = rating;
        }
        public TradablePlayer(Player player, decimal rating) : this(player.Name, player.Positions, rating) {}

        public decimal Rating { get; }
    }
}
