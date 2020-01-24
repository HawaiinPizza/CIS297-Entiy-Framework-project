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

namespace January23rd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Rectangle> rectangles;
        Fibonacci fib;
        public MainWindow()
        {
            InitializeComponent();
            rectangles = new List<Rectangle>();
            fib = new Fibonacci();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rectangle = new Rectangle();
            rectangle.setWidth(Convert.ToInt32(widthTextBox.Text));
            rectangle.setLength(Convert.ToInt32(lengthTextBox.Text));
            rectangles.Add(rectangle);

            rectanglesInfoLabel.Content = "";

            rectangles.Sort();

            foreach( var r in rectangles)
            {
                rectanglesInfoLabel.Content +=
                    $"Width: {r.getSideLength(1)} Length: {r.getSideLength(0)} Area: {r.getArea()}{Environment.NewLine}";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach( int f in fib )
            {
                fibonacciNumbersLabel.Content += $"{f}{Environment.NewLine}";
            }
        }
    }
}
