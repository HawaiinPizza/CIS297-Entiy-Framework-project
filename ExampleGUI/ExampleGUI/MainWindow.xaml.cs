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

namespace ExampleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random;
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            label.Content += $"Hello {textBox.Text}{random.Next(1,100)}{Environment.NewLine}";
            label.Content += comboBox.Text;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label.Content = slider.Value.ToString();
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox.Text != string.Empty)
            {
                if (e.Key == Key.Enter)
                {
                    label.Content += $"Hello {textBox.Text}{random.Next(1, 100)}{Environment.NewLine}";
                    textBox.Text = string.Empty;
                }
            }
        }

        private void standardDeductionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            handleRadioButton();
        }

        private void itemizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            handleRadioButton();
        }

        private void handleRadioButton()
        {
            // bool? means it might be null instead of just true or false
            if (itemizeRadioButton.IsChecked.HasValue && itemizeRadioButton.IsChecked.Value)
            {
                label.Content += "Itemize me!";
            }
            else if (standardDeductionRadioButton.IsChecked.HasValue && standardDeductionRadioButton.IsChecked.Value)
            {
                label.Content += "Standarize!";
            }
        }
    }
}
