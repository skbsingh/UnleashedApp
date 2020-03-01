using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnglishCurrencyConverter.Tests
{
    [TestClass]
    public class CurrencyConverterTest
    {
        [TestMethod]
        public void Validate_AmountToDecimal()
        {
            string input = "100.536";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            decimal result = currencyConverter.ConvertAmountToDecimal(input);
            Assert.AreEqual(Convert.ToDecimal(100.53), result);
        }

        [TestMethod]
        public void Validate_AmountToDecimal_CommaSeparated()
        {
            string input = "100,536.64503";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            decimal result = currencyConverter.ConvertAmountToDecimal(input);
            Assert.AreEqual(Convert.ToDecimal(100536.64), result);
        }

        [TestMethod]
        public void Validate_AmountToDecimal_Zero()
        {
            string input = "0000";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            decimal result = currencyConverter.ConvertAmountToDecimal(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Validate_AmountToDecimal_NonNumeric()
        {
            string input = "asdasd";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            decimal result = currencyConverter.ConvertAmountToDecimal(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Validate_SingleDigit_1_One()
        {
            int input = 1;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("One", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_2_Two()
        {
            int input = 2;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Two", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_3_Three()
        {
            int input = 3;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Three", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_4_Four()
        {
            int input = 4;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Four", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_5_Five()
        {
            int input = 5;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Five", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_6_Six()
        {
            int input = 6;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Six", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_7_Seven()
        {
            int input = 7;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Seven", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_8_Eight()
        {
            int input = 8;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Eight", result);
        }

        [TestMethod]
        public void Validate_SingleDigit_9_Nine()
        {
            int input = 9;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.SingleDigit(input);
            Assert.AreEqual("Nine", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_10_Ten()
        {
            int input = 10;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Ten", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_11_Eleven()
        {
            int input = 11;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Eleven", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_12_Twelve()
        {
            int input = 12;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Twelve", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_13_Thirteen()
        {
            int input = 13;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Thirteen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_14_Fourteen()
        {
            int input = 14;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Fourteen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_15_Fifteen()
        {
            int input = 15;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Fifteen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_16_Sixteen()
        {
            int input = 16;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Sixteen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_17_Seventeen()
        {
            int input = 17;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Seventeen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_18_Eighteen()
        {
            int input = 18;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Eighteen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_19_Nineteen()
        {
            int input = 19;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Nineteen", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_20_Twenty()
        {
            int input = 20;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Twenty", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_21_TwentyOne()
        {
            int input = 21;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Twenty One", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_30_Thirty()
        {
            int input = 30;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Thirty", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_40_Forty()
        {
            int input = 40;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Forty", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_50_Fifty()
        {
            int input = 50;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Fifty", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_60_Sixty()
        {
            int input = 60;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Sixty", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_70_Seventy()
        {
            int input = 70;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Seventy", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_80_Eighty()
        {
            int input = 80;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Eighty", result);
        }

        [TestMethod]
        public void Validate_DoubleDigit_90_Ninety()
        {
            int input = 90;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.DoubleDigitUnique(input);
            Assert.AreEqual("Ninety", result);
        }

        [TestMethod]
        public void Validate_NumbersToWords_351()
        {
            string input = "351";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.NumbersToWords(input);
            Assert.AreEqual("Three Hundred Fifty One", result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The amount entered is either zero or invalid input")]
        public void Validate_ConvertToEnglishCurrency_NegativeNumber()
        {
            string input = "-351";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_1058_01()
        {
            string input = "1058.01";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("One Thousand Fifty Eight Dollars and One Cent", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_5Cents()
        {
            string input = "00.05";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("Five Cents", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_100Billion()
        {
            string input = "100000000000.05";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("One Hundred Billion Dollars and Five Cents", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_Trillion()
        {
            string input = "7000000000000.05";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("Seven Trillion Dollars and Five Cents", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_17Trillion()
        {
            string input = "17000000000000.05";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("Seventeen Trillion Dollars and Five Cents", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_999Trillion()
        {
            string input = "999,000,000,000,000.05";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("Nine Hundred Ninety Nine Trillion Dollars and Five Cents", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_OneDollar15Cents()
        {
            string input = "1.15";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("One Dollar and Fifteen Cents", result);
        }

        [TestMethod]
        public void Validate_ConvertToEnglishCurrency_148Dollar68Cents()
        {
            string input = "148.68";
            CurrencyConverter currencyConverter = new CurrencyConverter();

            string result = currencyConverter.ConvertToEnglishCurrency(input);
            Assert.AreEqual("One Hundred Forty Eight Dollars and Sixty Eight Cents", result);
        }
    }
}
