using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
    public class YahtzeeGame
    {
        public YahtzeeDice dice { get; private set; }
        public YahtzeeScoreboard possibleScoreboard { get; private set; }
        public YahtzeeScoreboard savedScores { get; private set; }

        public bool HasScoredOnes { get; set; }
        public bool HasScoredTwos { get; set; }
        public bool HasScoredThrees { get; set; }
        public bool HasScoredFours { get; set; }
        public bool HasScoredFives { get; set; }
        public bool HasScoredSixes { get; set; }
        public bool HasScoredThreeOfAKind { get; set; }
        public bool HasScoredFourOfAKind { get; set; }
        public bool HasScoredFullHouse { get; set; }
        public bool HasScoredSmallStraight { get; set; }
        public bool HasScoredLargeStraight { get; set; }
        public bool HasScoredYahtzee { get; set; }
        public bool HasScoredChance { get; set; }


        public YahtzeeGame()
        {
            dice = new YahtzeeDice();
            possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
            savedScores = new YahtzeeScoreboard();
            HasScoredOnes = false;
            HasScoredTwos = false;
            HasScoredThrees = false;
            HasScoredFours = false;
            HasScoredFives = false;
            HasScoredSixes = false;
            HasScoredThreeOfAKind = false;
            HasScoredFourOfAKind = false;
            HasScoredFullHouse = false;
            HasScoredSmallStraight = false;
            HasScoredLargeStraight = false;
            HasScoredYahtzee = false;
            HasScoredChance = false;
        }

        public void Roll()
        {
            if (dice.NumberOfRolls < 3)
            {
                dice.Roll();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
            }
        }

        public bool IsGameOver()
        {
            return HasScoredOnes &&
                HasScoredTwos &&
                HasScoredThrees &&
                HasScoredFours &&
                HasScoredFives &&
                HasScoredSixes &&
                HasScoredThreeOfAKind &&
                HasScoredFourOfAKind &&
                HasScoredFullHouse &&
                HasScoredSmallStraight &&
                HasScoredLargeStraight &&
                HasScoredYahtzee &&
                HasScoredChance;
        }
        public bool ScoreOnes()
        {
            if (!HasScoredOnes)
            {
                savedScores.Ones = possibleScoreboard.Ones;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredOnes = true;
                return true;
            }
            return false;
        }
        public bool ScoreTwos()
        {
            if (!HasScoredTwos)
            {
                savedScores.Twos = possibleScoreboard.Twos;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredTwos = true;
                return true;
            }
            return false;
        }
        public bool ScoreThrees()
        {
            if (!HasScoredThrees)
            {
                savedScores.Threes = possibleScoreboard.Threes;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredThrees = true;
                return true;
            }
            return false;

        }
        public bool ScoreFours()
        {
            if (!HasScoredFours)
            {
                savedScores.Fours = possibleScoreboard.Fours;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredFours = true;
                return true;
            }
            return false;

        }
        public bool ScoreFives()
        {
            if (!HasScoredFives)
            {

                savedScores.Fives = possibleScoreboard.Fives;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredFives = true;
                return true;
            }
            return false;
        }
        public bool ScoreSixes()
        {
            if (!HasScoredSixes)
            {
                savedScores.Sixes = possibleScoreboard.Sixes;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredSixes = true;
                return true;
            }
            return false;
        }
        public bool ScoreThreeOfAKind()
        {
            if (!HasScoredThreeOfAKind)
            {
                savedScores.ThreeOfAKind = possibleScoreboard.ThreeOfAKind;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredThreeOfAKind = true;
                return true;
            }
            return false;
        }
        public bool ScoreFourOfAKind()
        {
            if (!HasScoredFourOfAKind)
            {
                savedScores.FourOfAKind = possibleScoreboard.FourOfAKind;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredFourOfAKind = true;
                return true;
            }
            return false;

        }
        public bool ScoreFullHouse()
        {
            if (!HasScoredFullHouse)
            {
                savedScores.FullHouse = possibleScoreboard.FullHouse;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredFullHouse = true;
                return true;
            }
            return false;
        }
        public bool ScoreSmallStraight()
        {
            if (!HasScoredSmallStraight)
            {
                savedScores.SmallStraight = possibleScoreboard.SmallStraight;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredSmallStraight = true;
                return true;
            }
            return false;
        }
        public bool ScoreLargeStraight()
        {
            if (!HasScoredLargeStraight)
            {
                savedScores.LargeStraight = possibleScoreboard.LargeStraight;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredLargeStraight = true;
                return true;
            }
            return false;
        }
        public bool ScoreYahtzee()
        {
            if (!HasScoredYahtzee)
            {
                savedScores.Yahtzee = possibleScoreboard.Yahtzee;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredYahtzee = true;
                return true;
            }
            return false;
        }
        public bool ScoreChance()
        {
            if (!HasScoredChance)
            {
                savedScores.Chance = possibleScoreboard.Chance;
                dice = new YahtzeeDice();
                possibleScoreboard = new YahtzeeScoreboard(dice.getDiceValues());
                HasScoredChance = true;
                return true;
            }
            return false;
        }
    }

    public class YahtzeeScoreboard
    {
        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }

        public int UpperSum => Ones + Twos + Threes + Fours + Fives + Sixes;
        public int Bonus => UpperSum >= 63 ? 35 : 0;

        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int FullHouse { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Yahtzee { get; set; }
        public int Chance { get; set; }

        public int TotalScore()
        {
            return ThreeOfAKind + FourOfAKind + FullHouse +
                SmallStraight + LargeStraight + Yahtzee + Chance
                + UpperSum + Bonus;
        }

        public YahtzeeScoreboard()
        {
            Ones = 0;
            Twos = 0;
            Threes = 0;
            Fours = 0;
            Fives = 0;
            Sixes = 0;

            ThreeOfAKind = 0;
            FourOfAKind = 0;
            FullHouse = 0;
            SmallStraight = 0;
            LargeStraight = 0;
            Yahtzee = 0;
            Chance = 0;
        }

        public YahtzeeScoreboard(int[] diceValues)
        {
            // oversizes so we have indexes 1-6 for use
            int[] numberOfOccurances = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            for (int index = 0; index < 5; index++)
            {
                int dieValue = diceValues[index];
                numberOfOccurances[dieValue]++;
            }

            Ones = numberOfOccurances[1];
            Twos = numberOfOccurances[2] * 2;
            Threes = numberOfOccurances[3] * 3;
            Fours = numberOfOccurances[4] * 4;
            Fives = numberOfOccurances[5] * 5;
            Sixes = numberOfOccurances[6] * 6;

            for (int index = 0; index < 5; index++)
            {
                int dieValue = diceValues[index];
                Chance += dieValue;
            }

            if (hasXNumberOfOccurances(numberOfOccurances, 3))
            {
                ThreeOfAKind = Chance;
            }
            if (hasXNumberOfOccurances(numberOfOccurances, 4))
            {
                ThreeOfAKind = Chance;
                FourOfAKind = Chance;
            }
            if (hasXNumberOfOccurances(numberOfOccurances, 5))
            {
                ThreeOfAKind = Chance;
                FourOfAKind = Chance;
                Yahtzee = 50;
            }

            if (hasXNumberOfOccurances(numberOfOccurances, 3) &&
                hasXNumberOfOccurances(numberOfOccurances, 2))
            {
                FullHouse = 25;
            }

            // not proud of this
            if ((numberOfOccurances[1] >= 1 &&
                numberOfOccurances[2] >= 1 &&
                numberOfOccurances[3] >= 1 &&
                numberOfOccurances[4] >= 1) ||
                (numberOfOccurances[2] >= 1 &&
                numberOfOccurances[3] >= 1 &&
                numberOfOccurances[4] >= 1 &&
                numberOfOccurances[5] >= 1) ||
                (numberOfOccurances[3] >= 1 &&
                numberOfOccurances[4] >= 1 &&
                numberOfOccurances[5] >= 1 &&
                numberOfOccurances[6] >= 1))
            {
                SmallStraight = 30;
            }

            // not proud of this
            if ((numberOfOccurances[1] >= 1 &&
                numberOfOccurances[2] >= 1 &&
                numberOfOccurances[3] >= 1 &&
                numberOfOccurances[4] >= 1 &&
                 numberOfOccurances[5] >= 1) ||
                (numberOfOccurances[2] >= 1 &&
                numberOfOccurances[3] >= 1 &&
                numberOfOccurances[4] >= 1 &&
                numberOfOccurances[5] >= 1 &&
                 numberOfOccurances[6] >= 1))
            {
                LargeStraight = 40;
            }
        }

        private bool hasXNumberOfOccurances(int[] numberOfOccurances, int occurances)
        {
            for (int index = 0; index < numberOfOccurances.Length; index++)
            {
                if (numberOfOccurances[index] == occurances)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class YahtzeeDice
    {
        public int NumberOfRolls { get; private set; }
        private int[] diceValues;
        private bool[] shouldRoll;
        private Random random;

        public int this[int index]
        {
            get
            {
                if ( index < 0 || index > 4 )
                {
                    throw new IndexOutOfRangeException();
                }
                return diceValues[index];
            }
        }

        public YahtzeeDice()
        {
            NumberOfRolls = 0;
            diceValues = new int[] { 0, 0, 0, 0, 0 };
            shouldRoll = new bool[] { true, true, true, true, true };
            random = new Random();
            Roll();
        }

        public int[] getDiceValues()
        {
            return diceValues;
        }
        public void Roll()
        {
            if (NumberOfRolls < 3)
            {
                NumberOfRolls++;

                for (int index = 0; index < diceValues.Length; index++)
                {
                    if (shouldRoll[index])
                    {
                        diceValues[index] = random.Next(1, 7);
                    }
                }
            }
        }

        public int getValueOfDieAtIndex(int index)
        {
            return diceValues[index];
        }

        public void changeShouldRollForIndex(int index, bool state)
        {
            shouldRoll[index] = state;
        }
    }
}
