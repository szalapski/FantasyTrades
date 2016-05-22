using System.Collections.Generic;
using System.Linq;

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
        
        public IEnumerable<Position> PositionCollection {
            get
            {
                var result = Positions
                    .Split(',')
                    .Select(s => Position.Parse(s))
                    .Where(p => p != null)
                    .ToList();

                return result;
            }
        }
    }
}