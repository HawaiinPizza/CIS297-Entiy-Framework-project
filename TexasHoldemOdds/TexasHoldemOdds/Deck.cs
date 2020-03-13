using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldemOdds
{
    public class Deck
    {
        public int CardsRemaining => _cards.Count;
        private Stack<Card> _cards;

        public Deck()
        {
            _cards = new Stack<Card>(52);
            List<Card> newDeck = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (var face in Enum.GetValues(typeof(Card.Face)))
                {
                    var card = new Card((Card.Face)face, (Card.Suit)suit);
                    newDeck.Add(card);
                }
            }
            Random random = new Random();
            for (int cardNumber = 0; cardNumber < 52; cardNumber++)
            {
                var index = random.Next(newDeck.Count);
                _cards.Push(newDeck[index]);
                newDeck.RemoveAt(index);
            }

        }

        public Card PickCard()
        {
            if (_cards.Count == 0)
            {
                throw new IndexOutOfRangeException("No cards left!");
            }
            return _cards.Pop();
        }
    }
}