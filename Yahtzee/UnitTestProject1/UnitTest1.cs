using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLargeStraight()
        {
            // Arrange
            int[] diceValues = new int[] { 1, 2, 3, 4, 5 };
            int expectedOnes = 1;
            int expectedTwos = 2;
            int expectedThrees = 3;
            int expectedFours = 4;
            int expectedFives = 5;
            int expectedSixes = 0;

            int expectedThreeOfKind = 0;
            int expectedFourOfAKind = 0;
            int expectedFullHouse = 0;
            int expectedSmallStraight = 30;
            int expectedLargeStraight = 40;
            int expectedYahtzee = 0;
            int expectedChance = 15;

            // Act
            var scorecard = new YahtzeeScoreboard(diceValues);


            // Assert
            Assert.AreEqual(expectedOnes, scorecard.Ones);
            Assert.AreEqual(expectedTwos, scorecard.Twos);
            Assert.AreEqual(expectedThrees, scorecard.Threes);
            Assert.AreEqual(expectedFours, scorecard.Fours);
            Assert.AreEqual(expectedFives, scorecard.Fives);
            Assert.AreEqual(expectedSixes, scorecard.Sixes);

            Assert.AreEqual(expectedThreeOfKind, scorecard.ThreeOfAKind);
            Assert.AreEqual(expectedFourOfAKind, scorecard.FourOfAKind);
            Assert.AreEqual(expectedFullHouse, scorecard.FullHouse);
            Assert.AreEqual(expectedSmallStraight, scorecard.SmallStraight);
            Assert.AreEqual(expectedLargeStraight, scorecard.LargeStraight);
            Assert.AreEqual(expectedYahtzee, scorecard.Yahtzee);
            Assert.AreEqual(expectedChance, scorecard.Chance);

        }

        [TestMethod]
        public void TestMethodSmallStraight()
        {
            // Arrange
            int[] diceValues = new int[] { 1, 2, 3, 4, 6 };
            int expectedOnes = 1;
            int expectedTwos = 2;
            int expectedThrees = 3;
            int expectedFours = 4;
            int expectedFives = 0;
            int expectedSixes = 6;

            int expectedThreeOfKind = 0;
            int expectedFourOfAKind = 0;
            int expectedFullHouse = 0;
            int expectedSmallStraight = 30;
            int expectedLargeStraight = 0;
            int expectedYahtzee = 0;
            int expectedChance = 16;

            // Act
            var scorecard = new YahtzeeScoreboard(diceValues);


            // Assert
            Assert.AreEqual(expectedOnes, scorecard.Ones);
            Assert.AreEqual(expectedTwos, scorecard.Twos);
            Assert.AreEqual(expectedThrees, scorecard.Threes);
            Assert.AreEqual(expectedFours, scorecard.Fours);
            Assert.AreEqual(expectedFives, scorecard.Fives);
            Assert.AreEqual(expectedSixes, scorecard.Sixes);

            Assert.AreEqual(expectedThreeOfKind, scorecard.ThreeOfAKind);
            Assert.AreEqual(expectedFourOfAKind, scorecard.FourOfAKind);
            Assert.AreEqual(expectedFullHouse, scorecard.FullHouse);
            Assert.AreEqual(expectedSmallStraight, scorecard.SmallStraight);
            Assert.AreEqual(expectedLargeStraight, scorecard.LargeStraight);
            Assert.AreEqual(expectedYahtzee, scorecard.Yahtzee);
            Assert.AreEqual(expectedChance, scorecard.Chance);

        }

        [TestMethod]
        public void TestMethodYahtzee()
        {
            // Arrange
            int[] diceValues = new int[] { 6, 6, 6, 6, 6 };
            int expectedOnes = 0;
            int expectedTwos = 0;
            int expectedThrees = 0;
            int expectedFours = 0;
            int expectedFives = 0;
            int expectedSixes = 30;

            int expectedThreeOfKind = 30;
            int expectedFourOfAKind = 30;
            int expectedFullHouse = 0;
            int expectedSmallStraight = 0;
            int expectedLargeStraight = 0;
            int expectedYahtzee = 50;
            int expectedChance = 30;

            // Act
            var scorecard = new YahtzeeScoreboard(diceValues);


            // Assert
            Assert.AreEqual(expectedOnes, scorecard.Ones);
            Assert.AreEqual(expectedTwos, scorecard.Twos);
            Assert.AreEqual(expectedThrees, scorecard.Threes);
            Assert.AreEqual(expectedFours, scorecard.Fours);
            Assert.AreEqual(expectedFives, scorecard.Fives);
            Assert.AreEqual(expectedSixes, scorecard.Sixes);

            Assert.AreEqual(expectedThreeOfKind, scorecard.ThreeOfAKind);
            Assert.AreEqual(expectedFourOfAKind, scorecard.FourOfAKind);
            Assert.AreEqual(expectedFullHouse, scorecard.FullHouse);
            Assert.AreEqual(expectedSmallStraight, scorecard.SmallStraight);
            Assert.AreEqual(expectedLargeStraight, scorecard.LargeStraight);
            Assert.AreEqual(expectedYahtzee, scorecard.Yahtzee);
            Assert.AreEqual(expectedChance, scorecard.Chance);

        }
    }
}
