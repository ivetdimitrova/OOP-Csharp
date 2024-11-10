using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Model
{
    public class Card
    {
        private readonly string[] _validFaces =
        {
            "1","2","3","4","5","6","7","8","9","10","Q","K","A"
        };

        private readonly Dictionary<char,string> _validSuit = new Dictionary<char, string>()
        {
            ['S'] = "\u2660",
            ['H'] = "\u2665",
            ['D'] = "\u2666",
            ['C'] = "\u2663"
        };


        private string _face;
        private char _suit;

        public Card(string face, char suit)
        {
            if (!_validFaces.Contains(face) || !_validSuit.ContainsKey(suit))
                throw new ArgumentException("Invalid card!");

            _face = face;
            _suit = suit;
        }


        public override string ToString()
        {
            return $"[{_face}{_validSuit[_suit]}]";
        }
    }
}
