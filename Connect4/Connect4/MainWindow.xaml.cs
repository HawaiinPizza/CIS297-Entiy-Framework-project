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

namespace Connect4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<List<Ellipse>> spaces;
        Connect4Game game;
        public MainWindow()
        {
            InitializeComponent();
            game = new Connect4Game();
            spaces = new List<List<Ellipse>>();

            for (int rowNumber = 0; rowNumber < 6; rowNumber++)

            {
                var row = new List<Ellipse>();

                for (int columnNumber = 0; columnNumber < 7; columnNumber++)
                {
                    var ellipse = new Ellipse();
                    ellipse.Height = 50;
                    ellipse.Width = 50;
                    ellipse.Stroke = Brushes.Black;
                    ellipse.StrokeThickness = 5;
                    ellipse.HorizontalAlignment = HorizontalAlignment.Left;
                    ellipse.VerticalAlignment = VerticalAlignment.Top;
                    ellipse.Margin = new Thickness(100 + (60 * columnNumber), 50 + (60 * rowNumber), 0, 0);
                    grid.Children.Add(ellipse);
                    row.Add(ellipse);
                }

                spaces.Add(row);
            }

            updateDisplay();
        }

        public void updateDisplay()
        {
            for (int rowIndex = 0; rowIndex < spaces.Count; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < spaces[rowIndex].Count; columnIndex++)
                {
                    var piece = game.getPieceAt(rowIndex, columnIndex);

                    if ( piece == Piece.Red )
                    {
                        spaces[rowIndex][columnIndex].Fill = new SolidColorBrush(Colors.Red);
                    }
                    else if ( piece == Piece.Green )
                    {
                        spaces[rowIndex][columnIndex].Fill = new SolidColorBrush(Colors.Green);
                    }
                       
                }
            }
            if ( game.getCurrentPlayer() == Piece.Red)
            {
                currentPlayerLabel.Content = nameof(Piece.Red);
            }
            else
            {
                currentPlayerLabel.Content = nameof(Piece.Green);
            }

            if (game.isTie())
            {
                errorLabel.Content = "TIE!";
                return;
            }
            if (game.isGameOver())
            {
                errorLabel.Content = game.getCurrentPlayer() == Piece.Red ? "Green wins!" : "Red Wins!";
                return;
            }

        }

        private void columnButton_Click(object sender, RoutedEventArgs e)
        {           
            errorLabel.Content = "";
            if (!game.isGameOver())
            {

                if (sender == column0Button)
                {
                    dropPiece(0);
                }
                else if (sender == column1Button)
                {
                    dropPiece(1);
                }
                else if (sender == column2Button)
                {
                    dropPiece(2);
                }
                else if (sender == column3Button)
                {
                    dropPiece(3);
                }
                else if (sender == column4Button)
                {
                    dropPiece(4);
                }
                else if (sender == column5Button)
                {
                    dropPiece(5);
                }
                else if (sender == column6Button)
                {
                    dropPiece(6);
                }
            }
            updateDisplay();
        }

        private void dropPiece(int columnIndex)
        {
            if (!game.dropPieceInColumn(columnIndex))
            {
                errorLabel.Content = "Pick a different column dummy!";
            }
        }
    }
}
