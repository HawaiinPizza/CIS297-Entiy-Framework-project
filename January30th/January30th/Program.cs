using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace January30th
{
    public enum Suit
    {
        Spaces, Hearts, Clubs, Diamonds
    };

    public enum Face
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    };

    public class Card : IComparable<Card>
    {
        public Face Face { get; private set; }
        public Suit Suit { get; private set; }

        public int CompareTo(Card other)
        {
            return Face.CompareTo(other.Face);
        }
    }

    public interface IDeck
    {
        Card draw();
    }

    public class PokerHand : IComparable<PokerHand>
    {
        private List<Card> hand;
        public PokerHand(IDeck deck)
        {
            hand = new List<Card> { deck.draw(), deck.draw(), deck.draw(), deck.draw(), deck.draw() };
        }

        public int CompareTo( PokerHand other)
        {
            throw new NotImplementedException();
        }
    }

    public class Bet<T> where T : IComparable<T>
    {
        T first;
        T second;
        int wager;
        public Bet(int wager, T first, T second)
        {
            this.wager = wager;
            this.first = first;
            this.second = second;
        }

        public T getWinner()
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            if (first.CompareTo(second) < 0)
            {
                return second;
            }

            // not proud of this
            throw new InvalidOperationException("There is no winner, you both lose!");
        }

        public int getWager()
        {
            return wager;
        }
    }


    public class ComparableTwoThings<T> where T : IComparable<T>
    {
        private T first;
        private T second;

        public ComparableTwoThings(T first, T second)
        {
            this.first = first;
            this.second = second;
        }

        public T getFirst()
        {
            return first;
        }

        public int CompareFirstToSecond()
        {
            return first.CompareTo(second);
        }
    }

    public class ComparableInterfaceTwoThings
    {
        private IComparable first;
        private IComparable second;

        public ComparableInterfaceTwoThings(IComparable first, IComparable second)
        {
            this.first = first;
            this.second = second;
        }

        public IComparable getFirst()
        {
            return first;
        }
        public int CompareFirstToSecond()
        {
            return first.CompareTo(second);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<GuessingGame> numbers = new List<GuessingGame> { new GuessingGame(10) };
            //ComparableTwoThings<GuessingGame> comparableThings = new ComparableTwoThings<GuessingGame>(new GuessingGame(10), new GuessingGame(10));


            Console.WriteLine("Enter a number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a wager: ");
            int wager = Convert.ToInt32(Console.ReadLine());

            Bet<int> newBet = new Bet<int>(wager, first, second);
            Console.WriteLine($"The winner is: {newBet.getWinner()}");
        }
    }
}
