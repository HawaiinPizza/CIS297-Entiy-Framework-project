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

namespace TaxCalculatorForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double grossIncome;
        private double totalDeductions;
        private TaxCalculator taxCalculator;
        public MainWindow()
        {
            InitializeComponent();
            grossIncome = 0;
            totalDeductions = 0;
            standardDeductionRadioButton.IsChecked = true;
            UpdateTaxSummary();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grossIncome += Convert.ToDouble(incomeTextBox.Text);
            grossIncomeLabel.Content = $"Gross Income: ${grossIncome}";
            UpdateTaxSummary();
        }

        private void standardDeductionButton_Checked(object sender, RoutedEventArgs e)
        {
            totalDeductions = 12200;
            UpdateTotalDeductionsLabel();
        }

        private void itemizeDeductionsButton_Checked(object sender, RoutedEventArgs e)
        {
            totalDeductions = 0;
            UpdateTotalDeductionsLabel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            totalDeductions += Convert.ToDouble(deductionsTextBox.Text);
            UpdateTotalDeductionsLabel();
        }

        private void UpdateTotalDeductionsLabel()
        {
            totalDeductionsLabel.Content = $"Total Deductions: ${totalDeductions}";
            UpdateTaxSummary();
        }

        private void UpdateTaxSummary()
        {
            taxCalculator = new TaxCalculator(grossIncome, totalDeductions);
            taxSummary.Content = "";
            taxSummary.Content +=($"Taxes owed at 10%: ${taxCalculator.TaxesOwedAt10Percent}{Environment.NewLine}");
            taxSummary.Content +=($"Taxes owed at 12%: ${taxCalculator.TaxesOwedAt12Percent}{Environment.NewLine}");
            taxSummary.Content +=($"Taxes owed at 22%: ${taxCalculator.TaxesOwedAt22Percent}{Environment.NewLine}");
            taxSummary.Content +=($"Taxes owed at 24%: ${taxCalculator.TaxesOwedAt24Percent}{Environment.NewLine}");
            taxSummary.Content +=($"Taxes owed at 32%: ${taxCalculator.TaxesOwedAt32Percent}{Environment.NewLine}");
            taxSummary.Content +=($"Taxes owed at 35%: ${taxCalculator.TaxesOwedAt35Percent}{Environment.NewLine}");
            taxSummary.Content +=($"Taxes owed at 37%: ${taxCalculator.TaxesOwedAt37Percent}{Environment.NewLine}");

            taxSummary.Content +=($"Total taxes owed: ${taxCalculator.TotalTaxesOwed}{Environment.NewLine}");

            taxSummary.Content +=($"Taxes as percetnage of gross income: {taxCalculator.TaxesAsPercentageOfGrossIncome}%{Environment.NewLine}");
            taxSummary.Content +=($"Taxes as percetnage of adjusted gross income: {taxCalculator.TaxesAsPercentageOfAGI}%{Environment.NewLine}");
        }
    }
}
