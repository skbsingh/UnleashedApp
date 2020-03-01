using System;

namespace EnglishCurrencyConverter
{
    public class CurrencyConverter
    {
        /// <summary>
        /// Converts user input to decimal amount rounding to two decimal places 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public decimal ConvertAmountToDecimal(string input)
        {
            decimal.TryParse(input, out decimal result);

            return Math.Truncate(100 * result) / 100;
        }

        /// <summary>
        /// Returns the word representation for a single digit number 
        /// </summary>
        /// <param name="singleNumber"></param>
        /// <returns></returns>
        public string SingleDigit(int singleNumber)
        {
            string singleWord = string.Empty;
            switch (singleNumber)
            {
                case 1:
                    singleWord = "One";
                    break;
                case 2:
                    singleWord = "Two";
                    break;
                case 3:
                    singleWord = "Three";
                    break;
                case 4:
                    singleWord = "Four";
                    break;
                case 5:
                    singleWord = "Five";
                    break;
                case 6:
                    singleWord = "Six";
                    break;
                case 7:
                    singleWord = "Seven";
                    break;
                case 8:
                    singleWord = "Eight";
                    break;
                case 9:
                    singleWord = "Nine";
                    break;
            }
            return singleWord;
        }

        /// <summary>
        /// Returns the word representation for a double digit number
        /// </summary>
        /// <param name="twoDigitNumber"></param>
        /// <returns></returns>
        public string DoubleDigitUnique(int twoDigitNumber)
        {
            string doubleWord = string.Empty;
            switch (twoDigitNumber)
            {
                case 10:
                    doubleWord = "Ten";
                    break;
                case 11:
                    doubleWord = "Eleven";
                    break;
                case 12:
                    doubleWord = "Twelve";
                    break;
                case 13:
                    doubleWord = "Thirteen";
                    break;
                case 14:
                    doubleWord = "Fourteen";
                    break;
                case 15:
                    doubleWord = "Fifteen";
                    break;
                case 16:
                    doubleWord = "Sixteen";
                    break;
                case 17:
                    doubleWord = "Seventeen";
                    break;
                case 18:
                    doubleWord = "Eighteen";
                    break;
                case 19:
                    doubleWord = "Nineteen";
                    break;
                case 20:
                    doubleWord = "Twenty";
                    break;
                case 30:
                    doubleWord = "Thirty";
                    break;
                case 40:
                    doubleWord = "Forty";
                    break;
                case 50:
                    doubleWord = "Fifty";
                    break;
                case 60:
                    doubleWord = "Sixty";
                    break;
                case 70:
                    doubleWord = "Seventy";
                    break;
                case 80:
                    doubleWord = "Eighty";
                    break;
                case 90:
                    doubleWord = "Ninety";
                    break;
                default:
                    if (twoDigitNumber > 0)
                    {
                        doubleWord = DoubleDigitUnique((twoDigitNumber / 10)*10) + " " + SingleDigit(twoDigitNumber % 10);
                    }
                    break;
            }
            return doubleWord;
        }


        /// <summary>
        /// Returns the word representation of a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string NumbersToWords(string number)
        {
            bool startsWithZero = false;
            bool isCompleted = false;

            string numbersInWords = "";
            long amount = (Convert.ToInt64(number));
            if (amount > 0)
            {
                int noOfDigits = number.Length;
                int position = 0;
                string place = "";

                startsWithZero = number.StartsWith("0");

                switch (noOfDigits)
                {
                    case 1:
                        numbersInWords = SingleDigit(Convert.ToInt32(amount));
                        isCompleted = true;
                        break;
                    case 2:
                        numbersInWords = DoubleDigitUnique(Convert.ToInt32(amount));
                        isCompleted = true;
                        break;
                    case 3:
                        position = (noOfDigits % 3) + 1;
                        place = " Hundred ";
                        break;
                    case 4:
                    case 5:
                    case 6:
                        position = (noOfDigits % 4) + 1;
                        place = " Thousand ";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        position = (noOfDigits % 7) + 1;
                        place = " Million ";
                        break;
                    case 10:
                    case 11:
                    case 12:
                        position = (noOfDigits % 10) + 1;
                        place = " Billion ";
                        break;
                    case 13:
                    case 14:
                    case 15:
                        position = (noOfDigits % 13) + 1;
                        place = " Trillion ";
                        break;
                    default:
                        isCompleted = true;
                        numbersInWords = "Cannot convert more than trillion";
                        break;
                }
                if (!isCompleted)
                {
                    if(number.Substring(0, position)!="0")
                    {
                        numbersInWords = NumbersToWords(number.Substring(0, position)) + place;
                    }
                    numbersInWords = numbersInWords + NumbersToWords(number.Substring(position));
                }
            }

            return numbersInWords.Trim();
        }

        /// <summary>
        /// Returns the words representation of the amount in english currency format
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string ConvertToEnglishCurrency(string amount)
        {
            string dollar = " Dollar";
            decimal decimalAmount = ConvertAmountToDecimal(amount);
            if(decimalAmount <= 0)
            {
                throw new Exception("The amount entered is either zero or invalid input");
            } else if (decimalAmount >= 2)
            {
                dollar += "s";
            }

            string formattedAmount = string.Format("{0:0.00}", decimalAmount);
            int decimalPlace = formattedAmount.IndexOf(".");

            string dollarAmount = formattedAmount.Substring(0,decimalPlace);
            string dollarWords = NumbersToWords(dollarAmount);
            if(dollarWords != "")
            {
                dollarWords = dollarWords + dollar;
            }

            string centAmount = formattedAmount.Substring(decimalPlace + 1);
            if(centAmount != "00")
            {
                dollarWords += (dollarWords != "") ? " and " : "";
                dollarWords = dollarWords + NumbersToWords(centAmount);
                dollarWords += (centAmount == "01") ? " Cent" : " Cents";
            }

            return dollarWords;
        }
    }
}
