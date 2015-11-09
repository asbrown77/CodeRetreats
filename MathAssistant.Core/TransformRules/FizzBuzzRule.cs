using System;
using System.Collections.Generic;
using MathAssistant.Core.Interfaces;

namespace MathAssistant.Core.TransformRules
{
    public class FizzBuzzRule : ITransformRule
    {
        public IList<Func<int, string, string>> Rules { get; private set; }
        
        public FizzBuzzRule()
        {
            Rules = new List<Func<int, string, string>>
            {
                FizzRule,
                BuzzRule,
                DefaultRule
            };
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