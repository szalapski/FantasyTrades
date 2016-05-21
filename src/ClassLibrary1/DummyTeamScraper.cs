using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class DummyTeamScraper : ITeamScraper
    {
        static bool _arrow = true;
        public void Populate(Team team)
        {
            if (_arrow)
            {
                team.Name = "Fake Nightmare";
                team.Players.Add(new Player("Welington Castillo", "C" ));
                team.Players.Add(new Player("Jose Abreu", "1B"));
                team.Players.Add(new Player("Jason Kipnis", "2B"));
                team.Players.Add(new Player("Adrian Beltre", "3B"));
                team.Players.Add(new Player("Xander Bogaerts", "SS"));
                team.Players.Add(new Player("Jung Ho Kang", "3B,SS"));
                team.Players.Add(new Player("Ryan Zimmerman", "1B"));
                team.Players.Add(new Player("Jose Bautista", "OF"));
                team.Players.Add(new Player("Hunter Pence", "OF"));
                team.Players.Add(new Player("Alex Gordon", "OF"));
                team.Players.Add(new Player("Miguel Sano", "OF"));
                team.Players.Add(new Player("Melky Cabrera", "OF"));
                team.Players.Add(new Player("Nick Markakis", "OF"));
                team.Players.Add(new Player("Howie Kendrick", "2B,OF"));
                team.Players.Add(new Player("Max Scherzer", "SP"));
                team.Players.Add(new Player("Wade Davis", "RP"));
                team.Players.Add(new Player("Kenta Maeda", "SP"));
                team.Players.Add(new Player("Cole Hamels", "SP"));
                team.Players.Add(new Player("John Lackey", "SP"));
                team.Players.Add(new Player("Jaime Garcia", "SP"));
                team.Players.Add(new Player("Jon Lester", "SP"));
                team.Players.Add(new Player("Francisco Rodriguez", "RP"));
                team.Players.Add(new Player("Tony Cingrani", "RP"));
                team.Players.Add(new Player("Blake Snell", "SP"));
                team.Players.Add(new Player("Steven Matz", "SP"));
                team.Players.Add(new Player("Nick Hundley", "C"));
                team.Players.Add(new Player("Kevin Plawecki", "C" ));
            }
            else
            {
                team.Name = "Fake Baeten";
                team.Players.Add(new Player("Paul Goldschmidt", "1B"));
                team.Players.Add(new Player("Rougned Odor", "2B"));
                team.Players.Add(new Player("Josh Donaldson", "3B"));
                team.Players.Add(new Player("Trevor Story", "SS"));
                team.Players.Add(new Player("Corey Seager", "SS"));
                team.Players.Add(new Player("Jake Lamb", "3B"));
                team.Players.Add(new Player("J.D. Martinez", "OF"));
                team.Players.Add(new Player("George Springer", "OF"));
                team.Players.Add(new Player("Yoenis Cespedes", "OF"));
                team.Players.Add(new Player("Gregory Polanco", "OF"));
                team.Players.Add(new Player("Odubel Herrera", "OF"));
                team.Players.Add(new Player("Zack Cozart", "SS"));
                team.Players.Add(new Player("A.J. Reed", "1B"));
                team.Players.Add(new Player("Ben Revere", "OF"));
                team.Players.Add(new Player("Jake Arrieta", "SP"));
                team.Players.Add(new Player("Jacob deGrom", "SP"));
                team.Players.Add(new Player("Jeurys Familia", "RP"));
                team.Players.Add(new Player("Aaron Sanchez", "RP,SP"));
                team.Players.Add(new Player("Kevin Gausman", "SP,RP"));
                team.Players.Add(new Player("Jimmy Nelson", "SP"));
                team.Players.Add(new Player("Nathan Karns", "SP"));
                team.Players.Add(new Player("Alex Wood", "SP"));
                team.Players.Add(new Player("Arodys Vizcaino", "RP"));
                team.Players.Add(new Player("Eduardo Rodriguez", "SP"));
                team.Players.Add(new Player("Raisel Iglesias", "SP"));
            }
            _arrow = !_arrow;
        }
    }
}
