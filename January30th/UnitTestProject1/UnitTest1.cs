using Microsoft.VisualStudio.TestTools.UnitTesting;
using January30th;

namespace UnitTestProject1
{
    class NotActuallyRandom : IRandom
    {
        private int fixedNumber;

        public NotActuallyRandom(int fixedNumber)
        {
            this.fixedNumber = fixedNumber;
        }

        public int Next(int maxNumber)
        {
            return fixedNumber;
        }
    }


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int magicNumber = 42;
            GuessingGame game = new GuessingGame(100, new NotActuallyRandom(magicNumber));

            var expectedTooHigh = "Too High!";
            var expectedTooLow = "Too low!";
            var expectedGotIt = "You guessed it!";

            Assert.AreEqual(expectedGotIt, game.guessANumber(42));
            Assert.AreEqual(expectedTooHigh, game.guessANumber(43));
            Assert.AreEqual(expectedTooLow, game.guessANumber(41));
        }
    }
}
