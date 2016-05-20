using System;

namespace Szalapski.FantasyTrades.Lib
{
    public class Team
    {
        public Team(Uri teamUri)
        {
            this.teamUri = teamUri;
        }
        private Uri teamUri;
    }
}