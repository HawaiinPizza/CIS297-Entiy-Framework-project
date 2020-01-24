using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorForm
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

            if (incomeToBeTaxed >= START_OF_37_PERCENT_BRACKET)
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
}
