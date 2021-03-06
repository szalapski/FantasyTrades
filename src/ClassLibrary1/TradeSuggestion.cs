﻿using System;
using System.Collections.Generic;

namespace Szalapski.FantasyTrades.Lib
{
    public class TradeSuggestion
    {
        public TradeSuggestion(Uri team1Uri, Uri team2Uri, EngineTweaks tweaks)
        {
            this.Team1 = new Team(team1Uri);
            this.Team2 = new Team(team2Uri);
            this.Tweaks = tweaks;
        }

        public List<Trade> TradesToTry { get; } = new List<Trade>();
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }

        public EngineTweaks Tweaks { get; private set; }
    }
}