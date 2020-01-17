using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTaxCalculator120kIncome()
        {
            // AAA

            // Arrange variables
            int grossIncome = 120000;
            int totalDeductions = 12200;
            double expectedTaxesAt10Percent = (TaxCalculator.TaxCalculator.START_OF_12_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_10_PERCENT_BRACKET) * .10;
            double expectedTaxesAt12Percent = (TaxCalculator.TaxCalculator.START_OF_22_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_12_PERCENT_BRACKET) * .12;
            double expectedTaxesAt22Percent = (TaxCalculator.TaxCalculator.START_OF_24_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_22_PERCENT_BRACKET) * .22;
            double expectedTaxesAt24Percent = (grossIncome - totalDeductions - TaxCalculator.TaxCalculator.START_OF_24_PERCENT_BRACKET) * .24;
            double expectedTaxesAt32Percent = 0;
            double expectedTaxesAt35Percent = 0;
            double expectedTaxesAt37Percent = 0;
            double expectedTotalTaxes = expectedTaxesAt10Percent + expectedTaxesAt12Percent +
                + expectedTaxesAt22Percent + expectedTaxesAt24Percent + 
                expectedTaxesAt32Percent + expectedTaxesAt35Percent + expectedTaxesAt37Percent;
            double expectedTaxesAsPercentageOfGrossIncome = expectedTotalTaxes / grossIncome * 100;
            double expectedTaxesAsPercentageOfAGI = expectedTotalTaxes / ( grossIncome - totalDeductions ) * 100;


            // Act - call some code we're testing
            var taxCalculator = new TaxCalculator.TaxCalculator(grossIncome, totalDeductions);

            // Assert - did we get what we expected
            Assert.AreEqual(expectedTaxesAt10Percent, taxCalculator.TaxesOwedAt10Percent);
            Assert.AreEqual(expectedTaxesAt12Percent, taxCalculator.TaxesOwedAt12Percent);
            Assert.AreEqual(expectedTaxesAt22Percent, taxCalculator.TaxesOwedAt22Percent);
            Assert.AreEqual(expectedTaxesAt24Percent, taxCalculator.TaxesOwedAt24Percent);
            Assert.AreEqual(expectedTaxesAt32Percent, taxCalculator.TaxesOwedAt32Percent);
            Assert.AreEqual(expectedTaxesAt35Percent, taxCalculator.TaxesOwedAt35Percent);
            Assert.AreEqual(expectedTaxesAt37Percent, taxCalculator.TaxesOwedAt37Percent);
            Assert.AreEqual(expectedTotalTaxes, taxCalculator.TotalTaxesOwed);
            Assert.AreEqual(expectedTaxesAsPercentageOfGrossIncome, taxCalculator.TaxesAsPercentageOfGrossIncome);
            Assert.AreEqual(expectedTaxesAsPercentageOfAGI, taxCalculator.TaxesAsPercentageOfAGI);

        }

        [TestMethod]
        public void TestMethodTaxCalculator1millionIncome()
        {
            // AAA

            // Arrange variables
            int grossIncome = 1_000_000;
            int totalDeductions = 12200;
            double expectedTaxesAt10Percent = (TaxCalculator.TaxCalculator.START_OF_12_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_10_PERCENT_BRACKET) * .10;
            double expectedTaxesAt12Percent = (TaxCalculator.TaxCalculator.START_OF_22_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_12_PERCENT_BRACKET) * .12;
            double expectedTaxesAt22Percent = (TaxCalculator.TaxCalculator.START_OF_24_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_22_PERCENT_BRACKET) * .22;
            double expectedTaxesAt24Percent = (TaxCalculator.TaxCalculator.START_OF_32_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_24_PERCENT_BRACKET) * .24;
            double expectedTaxesAt32Percent = (TaxCalculator.TaxCalculator.START_OF_35_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_32_PERCENT_BRACKET) * .32;
            double expectedTaxesAt35Percent = (TaxCalculator.TaxCalculator.START_OF_37_PERCENT_BRACKET - TaxCalculator.TaxCalculator.START_OF_35_PERCENT_BRACKET) * .35;
            double expectedTaxesAt37Percent = (grossIncome - totalDeductions - TaxCalculator.TaxCalculator.START_OF_37_PERCENT_BRACKET) * .37;
            double expectedTotalTaxes = expectedTaxesAt10Percent + expectedTaxesAt12Percent +
                +expectedTaxesAt22Percent + expectedTaxesAt24Percent +
                expectedTaxesAt32Percent + expectedTaxesAt35Percent + expectedTaxesAt37Percent;
            double expectedTaxesAsPercentageOfGrossIncome = expectedTotalTaxes / grossIncome * 100;
            double expectedTaxesAsPercentageOfAGI = expectedTotalTaxes / (grossIncome - totalDeductions) * 100;


            // Act - call some code we're testing
            var taxCalculator = new TaxCalculator.TaxCalculator(grossIncome, totalDeductions);

            // Assert - did we get what we expected
            Assert.AreEqual(expectedTaxesAt10Percent, taxCalculator.TaxesOwedAt10Percent);
            Assert.AreEqual(expectedTaxesAt12Percent, taxCalculator.TaxesOwedAt12Percent);
            Assert.AreEqual(expectedTaxesAt22Percent, taxCalculator.TaxesOwedAt22Percent);
            Assert.AreEqual(expectedTaxesAt24Percent, taxCalculator.TaxesOwedAt24Percent);
            Assert.AreEqual(expectedTaxesAt32Percent, taxCalculator.TaxesOwedAt32Percent);
            Assert.AreEqual(expectedTaxesAt35Percent, taxCalculator.TaxesOwedAt35Percent);
            Assert.AreEqual(expectedTaxesAt37Percent, taxCalculator.TaxesOwedAt37Percent);
            Assert.AreEqual(expectedTotalTaxes, taxCalculator.TotalTaxesOwed);
            Assert.AreEqual(expectedTaxesAsPercentageOfGrossIncome, taxCalculator.TaxesAsPercentageOfGrossIncome);
            Assert.AreEqual(expectedTaxesAsPercentageOfAGI, taxCalculator.TaxesAsPercentageOfAGI);

        }
    }
}
