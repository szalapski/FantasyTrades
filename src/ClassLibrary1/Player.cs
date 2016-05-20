namespace Szalapski.FantasyTrades.Lib
{
    public class Player
    {
        public Player(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; private set; }
    }
}