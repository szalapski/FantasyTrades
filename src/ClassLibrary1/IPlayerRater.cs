namespace Szalapski.FantasyTrades.Lib
{
    public interface IPlayerRater
    {
        decimal Rate(Player player1);
        decimal MaxRating { get; }
    }
}