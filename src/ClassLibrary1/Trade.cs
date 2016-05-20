using System.Collections.Generic;
using System.Linq;

namespace Szalapski.FantasyTrades.Lib
{
    public class Trade
    {
        public Trade(IEnumerable<Player> giveUp, IEnumerable<Player> receive)
        {
            GiveUp = giveUp.ToArray();
            Receive = receive.ToArray();
        }
        public Trade(Player giveUp, Player receive) : this(new[] { giveUp }, new[] { receive}) {}

        public Player[] GiveUp { get; private set; }
        public Player[] Receive { get; private set; }
    }
}