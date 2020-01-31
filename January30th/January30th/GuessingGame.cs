using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace January30th
{
    public interface IRandom
    {
        int Next(int maxNumber);
    }

    public class ActuallyRandom : IRandom
    {
        private Random random;

            public ActuallyRandom()
        {
            random = new Random();
        }
        public int Next(int maxNumber)
        {
            return random.Next(maxNumber);
        }
    }


    public class GuessingGame : IComparable<GuessingGame>
    {
        private int magicNumber;

        public GuessingGame(int maxNumber, IRandom random = null)
        {
            if ( random == null )
            {
                random = new ActuallyRandom();
            }
            magicNumber = random.Next(maxNumber + 1);
        }

        public int CompareTo(GuessingGame other)
        {
            return magicNumber.CompareTo(other.magicNumber);
        }

        public string guessANumber(int guess)
        {
            if (guess == magicNumber)
            {
                return "You guessed it!";

            }
            if (guess < magicNumber)
            {
                return "Too low!";
            }

            return "Too High!";

        }
    }
}
