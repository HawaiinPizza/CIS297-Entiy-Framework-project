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

namespace February13th
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Numbers numbers;
        public MainWindow()
        {
            InitializeComponent();
            numbers = new Numbers();
            numbers.NumbersChanged += HandleNumbersChanged;
        }

        public void HandleNumbersChanged(object sender, EventArgs args)
        {
            NumbersLabel.Content = $"{numbers.Number1} {numbers.Number2} {numbers.Number3} {numbers.Number4} {numbers.Number5}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numbers.ChangeNumbers();
        }
    }
}
