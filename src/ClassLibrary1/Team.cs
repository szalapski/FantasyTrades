using System;

namespace Szalapski.FantasyTrades.Lib
{
    public class Team
    {
        public Team(Uri teamUri)
        {
            TeamUri = teamUri;
        }

        public Uri TeamUri {get; private set;}
    }
}