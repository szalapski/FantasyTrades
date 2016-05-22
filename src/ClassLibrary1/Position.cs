using System;
using System.Linq;

namespace Szalapski.FantasyTrades.Lib
{
    public class Position
    {
        public string Token { get; private set; }

        public static readonly Position C = new Position("C");
        public static readonly Position _1B = new Position("1B");
        public static readonly Position _2B = new Position("2B");
        public static readonly Position _3B = new Position("3B");
        public static readonly Position SS = new Position("SS");
        public static readonly Position OF = new Position("OF");
        public static readonly Position DH = new Position("DH");
        public static readonly Position SP = new Position("SP");
        public static readonly Position RP = new Position("RP");

        public static Position Parse(string token)
        {
            token = token.Trim().Trim(',').ToUpper();
            string[] validTokens = new[] { "C", "1B", "2B", "3B", "SS", "OF", "DH", "SP", "RP" };
            if (validTokens.Contains(token)) return new Position(token);
            else return null;
        }
        private Position(string token)
        {
            Token = token;
        }

        public bool Equals(Position obj) => obj.Token == this.Token;
        public override bool Equals(Object obj)
        {
            if (!(obj is Position)) throw new InvalidCastException();
            return (obj as Position) == this;
        }
        public override int GetHashCode() => Token.GetHashCode();
        public static bool operator ==(Position a, Position b) => ((Object)a == null && (Object)b == null) 
            || ((Object)a != null && (Object)b != null && a.Token == b.Token);
        public static bool operator !=(Position a, Position b) => !(a == b);
    }
}