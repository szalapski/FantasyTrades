namespace Szalapski.FantasyTrades.Lib
{
    public class Player
    {
        public Player(string name, string positions)
        {
            Name = name;
            Positions = positions;
        }
        public string Name { get; private set; }
        public string Positions { get; private set; }
    }
}