using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class DummyTeamScraper : ITeamScraper
    {
        public void Populate(Team team)
        {
            team.Name = "The Bobs";
            team.Players.Add(new Player("Bob"));
            team.Players.Add(new Player("Bob2"));
            team.Players.Add(new Player("Bob3"));
        }
    }
}
