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
        Connect4Game game = new Connect4Game();
        public MainWindow()
        {
            InitializeComponent();
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

            updatePieces();

        }

        public void updatePieces()
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
        }
    }
}
