using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szalapski.FantasyTrades.Lib
{
    public class DummyTeamScraper : ITeamScraper
    {
        static bool _arrow = false;
        public void Populate(Team team)
        {
            string[] players;
            if (_arrow)
            {
                team.Name = "Fake Nightmare";
                players = new []
                {
                    "Welington Castillo",
                    "Jose Abreu",
                    "Jason Kipnis",
                    "Adrian Beltre",
                    "Xander Bogaerts",
                    "Jung Ho Kang",
                    "Ryan Zimmerman",
                    "Jose Bautista",
                    "Hunter Pence",
                    "Alex Gordon",
                    "Miguel Sano",
                    "Melky Cabrera",
                    "Nick Markakis",
                    "Howie Kendrick",
                    "Max Scherzer",
                    "Wade Davis",
                    "Kenta Maeda",
                    "Cole Hamels",
                    "John Lackey",
                    "Jaime Garcia",
                    "Jon Lester",
                    "Francisco Rodriguez",
                    "Tony Cingrani",
                    "Blake Snell",
                    "Steven Matz",
                    "Nick Hundley",
                    "Kevin Plawecki"
                };
            }
            else
            {
                team.Name = "Fake Baeten";
                players = new[]
                {
                    "Paul Goldschmidt",
                    "Rougned Odor",
                    "Josh Donaldson",
                    "Trevor Story",
                    "Corey Seager",
                    "Jake Lamb",
                    "J.D. Martinez",
                    "George Springer",
                    "Yoenis Cespedes",
                    "Gregory Polanco",
                    "Odubel Herrera",
                    "Zack Cozart",
                    "A.J. Reed",
                    "Ben Revere",
                    "Jake Arrieta",
                    "Jacob deGrom",
                    "Jeurys Familia",
                    "Aaron Sanchez",
                    "Kevin Gausman",
                    "Jimmy Nelson",
                    "Nathan Karns",
                    "Alex Wood",
                    "Arodys Vizcaino",
                    "Eduardo Rodriguez",
                    "Raisel Iglesias"
                };
            }
            foreach (string p in players) team.Players.Add(new Player(p));
            _arrow = !_arrow;
        }
    }
}
