using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHoldemOdds
{
    public partial class Form1 : Form
    {
        TexasHoldemGame game;
        public Form1()
        {
            InitializeComponent();
            game = new TexasHoldemGame();
            NewRound();
            newRoundButton.Enabled = false;
        }

        private void NewRound()
        {
            game.NewRound();

            playerHandLabel.Text = game.user.hand.ToString();

            sharedCardsLabel.Text = "Shared Cards: " + game.sharedCards.ToString();

            playerBestHandLabel.Text = game.user.hand.GetBestHand(game.sharedCards).ToString();

            var playerOdds = game.user.hand.GetOddsOfWinningDrawingAndLosing(game.sharedCards);
            playerOddsLabel.Text = $"Win {playerOdds.Item1} - Draw {playerOdds.Item2} - Lose {playerOdds.Item3}";

            
            playerMoneyLabel.Text = $"${game.user.Money}";
            computerMoneyLabel.Text = $"${game.computer.Money}";

            potLabel.Text = $"${game.pot}";

            computerHandLabel.Text = "Computer Hand: ";
            computerBestHandLabel.Text = "Computer's Best Hand: ";
            computerOddsLabel.Text = "";
        }

        public void showComputerStats()
        {
            computerHandLabel.Text = "Computer Hand: " + game.computer.hand.ToString();
            computerBestHandLabel.Text = "Computer's Best Hand: " + game.computer.hand.GetBestHand(game.sharedCards).ToString();
            var computerOdds = game.computer.hand.GetOddsOfWinningDrawingAndLosing(game.sharedCards);
            computerOddsLabel.Text = $"Win {computerOdds.Item1} - Draw {computerOdds.Item2} - Lose {computerOdds.Item3}";

        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            game.fold(game.user);
            newRoundButton.Enabled = true;
        }

        private void raiseButton_Click(object sender, EventArgs e)
        {
            game.playerRaise();

            var computerOdds = game.computer.hand.GetOddsOfWinningDrawingAndLosing(game.sharedCards);
            if ( computerOdds.Item1 >= .5 )
            {
                game.computerCalls();
            }
            else
            {
                game.fold(game.computer);
            }

            newRoundButton.Enabled = true;
        }
    }
}
