using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldemOdds
{
    public class TexasHoldemGame
    {
        public Player user { get; set; }
        public Player computer { get; set; }
        public Deck deck { get; set; }
        public int pot { get; set; }
        public SharedCards sharedCards { get; set; }

        public TexasHoldemGame()
        {
            user = new Player();
            computer = new Player();
            deck = new Deck();
            pot = 0;
            sharedCards = new SharedCards();
        }

        public void NewRound()
        {
            pot += user.Bet();
            pot += computer.Bet();
            deck = new Deck();
            user.hand.First = deck.PickCard();
            user.hand.Second = deck.PickCard();
            computer.hand.First = deck.PickCard();
            computer.hand.Second = deck.PickCard();
            sharedCards.Cards = new Card[] {
                deck.PickCard(),
                deck.PickCard(),
                deck.PickCard(),
                deck.PickCard(),
                deck.PickCard()
            };
        }

        public void playerRaise()
        {
            pot += user.Raise();
        }

        public void computerCalls()
        {
            pot += computer.Raise();
        }

        public void fold(Player player)
        {
            if (player == user)
            {
                computer.Money += pot;
            }
            else
            {
                user.Money += pot;
            }
            pot = 0;
        }

        public void getWinner()
        {
            var usersBestHand = user.hand.GetBestHand(sharedCards);
            var computersBestHand = computer.hand.GetBestHand(sharedCards);

            if (usersBestHand.CompareTo(computersBestHand) > 0)
            {
                user.Money += pot;
            }
            else if (usersBestHand.CompareTo(computersBestHand) < 0)
            {
                computer.Money += pot;
            }
            else
            {
                user.Money += pot / 2;
                computer.Money += pot / 2;
            }

            pot = 0;
        }
    }
}
