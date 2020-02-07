using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yahtzee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private YahtzeeGame yahtzeeGame;
        public MainWindow()
        {
            InitializeComponent();
            yahtzeeGame = new YahtzeeGame();
            updateLabels();
        }

        private void holdDie1CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            yahtzeeGame.dice.changeShouldRollForIndex(0, !holdDie1CheckBox.IsChecked.Value);
        }

        private void holdDie2CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            yahtzeeGame.dice.changeShouldRollForIndex(1, !holdDie2CheckBox.IsChecked.Value);
        }

        private void holdDie3CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            yahtzeeGame.dice.changeShouldRollForIndex(2, !holdDie3CheckBox.IsChecked.Value);
        }

        private void holdDie4CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            yahtzeeGame.dice.changeShouldRollForIndex(3, !holdDie4CheckBox.IsChecked.Value);
        }

        private void holdDie5CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            yahtzeeGame.dice.changeShouldRollForIndex(4, !holdDie5CheckBox.IsChecked.Value);
        }

        private void rollButton_Click(object sender, RoutedEventArgs e)
        {
            yahtzeeGame.Roll();
            if ( yahtzeeGame.dice.NumberOfRolls == 3 )
            {
                rollButton.IsEnabled = false;
            }
            updateLabels();
        }

        private void updateLabels()
        {
            die1Label.Content = yahtzeeGame.dice.getDiceValues()[0];
            die2Label.Content = yahtzeeGame.dice.getDiceValues()[1];
            die3Label.Content = yahtzeeGame.dice.getDiceValues()[2];
            die4Label.Content = yahtzeeGame.dice.getDiceValues()[3];
            die5Label.Content = yahtzeeGame.dice.getDiceValues()[4];

            var onesScore = yahtzeeGame.HasScoredOnes ? yahtzeeGame.savedScores.Ones : yahtzeeGame.possibleScoreboard.Ones;
            onesScoreLabel.Content = $"Ones: {onesScore}";

            var twosScore = yahtzeeGame.HasScoredTwos ? yahtzeeGame.savedScores.Twos : yahtzeeGame.possibleScoreboard.Twos;
            twosScoreLabel.Content = $"Twos: {twosScore}";

            var threesScore = yahtzeeGame.HasScoredThrees ? yahtzeeGame.savedScores.Threes : yahtzeeGame.possibleScoreboard.Threes;
            threesScoreLabel.Content = $"Threes: {threesScore}";

            var foursScore = yahtzeeGame.HasScoredFours ? yahtzeeGame.savedScores.Fours : yahtzeeGame.possibleScoreboard.Fours;
            foursScoreLabel.Content = $"Fours: {foursScore}";

            var fivesScore = yahtzeeGame.HasScoredFives ? yahtzeeGame.savedScores.Fives : yahtzeeGame.possibleScoreboard.Fives;
            fivesScoreLabel.Content = $"Fives: {fivesScore}";

            var sixesScore = yahtzeeGame.HasScoredSixes ? yahtzeeGame.savedScores.Sixes : yahtzeeGame.possibleScoreboard.Sixes;
            sixesScoreLabel.Content = $"Sixes: {sixesScore}";

            upperSumScoreLabel.Content = $"Upper sum: {yahtzeeGame.savedScores.UpperSum}";
            bonusScoreLabel.Content = $"Bonus: {yahtzeeGame.savedScores.Bonus}";

            var threeOfAKindScore = yahtzeeGame.HasScoredThreeOfAKind ? yahtzeeGame.savedScores.ThreeOfAKind : yahtzeeGame.possibleScoreboard.ThreeOfAKind;
            threeOfAkindScoreLabel.Content = $"Three of a kind: {threeOfAKindScore}";

            var fourOfAKindScore = yahtzeeGame.HasScoredFourOfAKind ? yahtzeeGame.savedScores.FourOfAKind : yahtzeeGame.possibleScoreboard.FourOfAKind;
            fourOfAKindScoreLabel.Content = $"Four of a kind: {fourOfAKindScore}";

            var fullHouseScore = yahtzeeGame.HasScoredFullHouse ? yahtzeeGame.savedScores.FullHouse : yahtzeeGame.possibleScoreboard.FullHouse;
            fullHouseScoreLabel.Content = $"Full House: {fullHouseScore}";

            var smallStraigthScore = yahtzeeGame.HasScoredSmallStraight ? yahtzeeGame.savedScores.SmallStraight : yahtzeeGame.possibleScoreboard.SmallStraight;
            smallStraightScoreLabel.Content = $"Small straight: {smallStraigthScore}";

            var largeStraightScore = yahtzeeGame.HasScoredLargeStraight ? yahtzeeGame.savedScores.LargeStraight : yahtzeeGame.possibleScoreboard.LargeStraight;
            largeStraightScoreLabel.Content = $"Large straight: {largeStraightScore}";

            var yahtzeeScore = yahtzeeGame.HasScoredYahtzee ? yahtzeeGame.savedScores.Yahtzee : yahtzeeGame.possibleScoreboard.Yahtzee;
            yahtzeeScoreLabel.Content = $"Yahtzee: {yahtzeeScore}";

            var chanceScore = yahtzeeGame.HasScoredChance ? yahtzeeGame.savedScores.Chance : yahtzeeGame.possibleScoreboard.Chance;
            chanceScoreLabel.Content = $"Chance: {chanceScore}";

            totalScoreLabel.Content = $"Total: {yahtzeeGame.savedScores.TotalScore()}";
        }

        private void resetRollButtonAndHoldCheckboxes()
        {
            if ( yahtzeeGame.IsGameOver() )
            {
                rollButton.Content = "GAME OVER!";
            }
            else
            {
                rollButton.IsEnabled = true;
                holdDie1CheckBox.IsChecked = false;
                holdDie2CheckBox.IsChecked = false;
                holdDie3CheckBox.IsChecked = false;
                holdDie4CheckBox.IsChecked = false;
                holdDie5CheckBox.IsChecked = false;
            }

            updateLabels();
           
        }

        private void onesScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ( yahtzeeGame.ScoreOnes() )
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void twosScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreTwos())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void threesScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreThrees())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void foursScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreFours())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void fivesScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreFives())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void sixesScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreSixes())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void threeOfAkindScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreThreeOfAKind())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void fourOfAKindScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreFourOfAKind())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void fullHouseScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreFullHouse())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void smallStraightScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreSmallStraight())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void largeStraightScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreLargeStraight())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void yahtzeeScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreYahtzee())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }

        private void chanceScoreLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (yahtzeeGame.ScoreChance())
            {
                resetRollButtonAndHoldCheckboxes();
            }
        }
    }
}
