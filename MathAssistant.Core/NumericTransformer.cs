using System;
using System.Collections.Generic;

namespace MathAssistant.Core
{
    public class NumericTransformer : INumericTransformer
    {
        public string Transform(int number)
        {
            var returnString = String.Empty;

            returnString = FizzRule(number, returnString);
            returnString = BuzzRule(number, returnString);
            returnString = DefaultRule(number, returnString);

            return returnString;
        }
       
        private static string BuzzRule(int number, string returnString)
        {
            if (IsBuzz(number))
            {
                returnString += "Buzz";
            }
            return returnString;
        }

        private static string FizzRule(int number, string returnString)
        {
            if (IsFizz(number))
                returnString = "Fizz";
            return returnString;
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 ==0;
        }

        private static bool IsFizz(int number)
        {
            return number % 3 ==0;
        }

        private static string DefaultRule(int number, string returnString)
        {
            if (String.IsNullOrEmpty(returnString))
            {
                returnString = number.ToString();
            }
            return returnString;
        }

    }
}