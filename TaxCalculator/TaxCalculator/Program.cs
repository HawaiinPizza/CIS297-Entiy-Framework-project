using System;

namespace TaxCalculator
{
    public class TaxCalculator
    {
        public double TaxesOwedAt10Percent { get; private set; }
        public double TaxesOwedAt12Percent { get; private set; }
        public double TaxesOwedAt22Percent { get; private set; }
        public double TaxesOwedAt24Percent { get; private set; }
        public double TaxesOwedAt32Percent { get; private set; }
        public double TaxesOwedAt35Percent { get; private set; }
        public double TaxesOwedAt37Percent { get; private set; }

        public double TotalTaxesOwed { get; private set; }
        public double TaxesAsPercentageOfAGI { get; private set; }
        public double TaxesAsPercentageOfGrossIncome { get; private set; }

        public static int START_OF_37_PERCENT_BRACKET = 510_300;
        public static int START_OF_35_PERCENT_BRACKET = 204_100;
        public static int START_OF_32_PERCENT_BRACKET = 160_725;
        public static int START_OF_24_PERCENT_BRACKET = 84_200;
        public static int START_OF_22_PERCENT_BRACKET = 39_475;
        public static int START_OF_12_PERCENT_BRACKET = 9_700;
        public static int START_OF_10_PERCENT_BRACKET = 0;

        public TaxCalculator(double grossIncome, double totalDeductions)
        {
            double incomeToBeTaxed = grossIncome - totalDeductions;

            if ( incomeToBeTaxed >= START_OF_37_PERCENT_BRACKET )
            {
                TaxesOwedAt37Percent = (incomeToBeTaxed - START_OF_37_PERCENT_BRACKET) * .37;
                incomeToBeTaxed = START_OF_37_PERCENT_BRACKET;
            }
            if (incomeToBeTaxed >= START_OF_35_PERCENT_BRACKET)
            {
                TaxesOwedAt35Percent = (incomeToBeTaxed - START_OF_35_PERCENT_BRACKET) * .35;
                incomeToBeTaxed = START_OF_35_PERCENT_BRACKET;
            }
            if (incomeToBeTaxed >= START_OF_32_PERCENT_BRACKET)
            {
                TaxesOwedAt32Percent = (incomeToBeTaxed - START_OF_32_PERCENT_BRACKET) * .32;
                incomeToBeTaxed = START_OF_32_PERCENT_BRACKET;
            }
            if (incomeToBeTaxed >= START_OF_24_PERCENT_BRACKET)
            {
                TaxesOwedAt24Percent = (incomeToBeTaxed - START_OF_24_PERCENT_BRACKET) * .24;
                incomeToBeTaxed = START_OF_24_PERCENT_BRACKET;
            }
            if (incomeToBeTaxed >= START_OF_22_PERCENT_BRACKET)
            {
                TaxesOwedAt22Percent = (incomeToBeTaxed - START_OF_22_PERCENT_BRACKET) * .22;
                incomeToBeTaxed = START_OF_22_PERCENT_BRACKET;
            }
            if (incomeToBeTaxed >= START_OF_12_PERCENT_BRACKET)
            {
                TaxesOwedAt12Percent = (incomeToBeTaxed - START_OF_12_PERCENT_BRACKET) * .12;
                incomeToBeTaxed = START_OF_12_PERCENT_BRACKET;
            }
            if (incomeToBeTaxed >= START_OF_10_PERCENT_BRACKET)
            {
                TaxesOwedAt10Percent = (incomeToBeTaxed - START_OF_10_PERCENT_BRACKET) * .10;
                incomeToBeTaxed = START_OF_10_PERCENT_BRACKET;
            }
            TotalTaxesOwed = TaxesOwedAt37Percent + TaxesOwedAt35Percent + TaxesOwedAt32Percent + TaxesOwedAt24Percent
                + TaxesOwedAt22Percent + TaxesOwedAt12Percent + TaxesOwedAt10Percent;

            TaxesAsPercentageOfGrossIncome = TotalTaxesOwed / grossIncome * 100;
            TaxesAsPercentageOfAGI = TotalTaxesOwed / (grossIncome - totalDeductions) * 100;
        }
    }
    class Program
    {
        static int STANDARD_DEDUCTION = 12_200;
        static void Main(string[] args)
        {
            double grossIncome = 0;
            double totalDeductions = 0;
            double income = 0;

            do
            {
                Console.WriteLine("Enter your W2 income or 0 to stop");
                income = Convert.ToDouble(Console.ReadLine());
                grossIncome += income;
            } while (income != 0);

            string useStandardDeduction = string.Empty;

            Console.WriteLine("Do you want to use the standard deduction ( $12,000 ) Y/N");
            useStandardDeduction = Console.ReadLine();

            if ( useStandardDeduction == "Y" )
            {
                totalDeductions = STANDARD_DEDUCTION;
            }
            else
            {
                double deduction = 0;
                do
                {
                    Console.WriteLine("Enter your deduction or 0 to stop");
                    deduction = Convert.ToDouble(Console.ReadLine());
                    totalDeductions += deduction;
                } while (deduction != 0);
            }

            TaxCalculator taxCalculator = new TaxCalculator(grossIncome, totalDeductions);

            Console.WriteLine($"Taxes owed at 10%: ${taxCalculator.TaxesOwedAt10Percent}");
            Console.WriteLine($"Taxes owed at 12%: ${taxCalculator.TaxesOwedAt12Percent}");
            Console.WriteLine($"Taxes owed at 22%: ${taxCalculator.TaxesOwedAt22Percent}");
            Console.WriteLine($"Taxes owed at 24%: ${taxCalculator.TaxesOwedAt24Percent}");
            Console.WriteLine($"Taxes owed at 32%: ${taxCalculator.TaxesOwedAt32Percent}");
            Console.WriteLine($"Taxes owed at 35%: ${taxCalculator.TaxesOwedAt35Percent}");
            Console.WriteLine($"Taxes owed at 37%: ${taxCalculator.TaxesOwedAt37Percent}");

            Console.WriteLine($"Total taxes owed: ${taxCalculator.TotalTaxesOwed}");

            Console.WriteLine($"Taxes as percetnage of gross income: {taxCalculator.TaxesAsPercentageOfGrossIncome}%");
            Console.WriteLine($"Taxes as percetnage of adjusted gross income: {taxCalculator.TaxesAsPercentageOfAGI}%");
        }
    }
}
