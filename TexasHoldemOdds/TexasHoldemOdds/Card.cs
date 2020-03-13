using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldemOdds
{
    public class Card : IComparable<Card>
    {
        public enum Suit { Spades = 1, Hearts = 0, Clubs = 3, Diamonds = 2 };
        public enum Face { Ace = 14, King = 13, Queen = 12, Jack = 11, Ten = 10, Nine = 9, Eight = 8, Seven = 7, Six = 6, Five = 5, Four = 4, Three = 3, Two = 2 }

        public Suit suit { get; set; }
        public Face face { get; set; }

        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public int CompareTo(Card other)
        {
            return (int)face - (int)other.face;
        }

        public override string ToString()
        {
            return $"{face} of {suit}";
        }

    }
}
