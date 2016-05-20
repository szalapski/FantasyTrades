using System;
using System.Collections.Generic;

namespace Szalapski.FantasyTrades.Lib
{
    public class Team
    {
        public Team(Uri teamUri)
        {
            TeamUri = teamUri;
        }

        public Uri TeamUri {get; private set;}

        public string Name { get; set;}
        public List<Player> Players { get; } = new List<Player>();

        

    }
}