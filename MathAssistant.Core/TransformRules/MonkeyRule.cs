using System;
using System.Collections.Generic;
using MathAssistant.Core.Interfaces;

namespace MathAssistant.Core.TransformRules
{
    public class MonkeyRule : ITransformRule
    {
        public IList<Func<int, string, string>> Rules { get; private set; }

        public MonkeyRule()
        {
            Rules = new List<Func<int, string, string>>
            {
                MonkeyStandardRule,
                Default
            };
        }

        private string MonkeyStandardRule(int number, string returnString)
        {
            if (IsMonkey(number))
            {
                return "Monkey";
            }

            return returnString;
        }

        private static bool IsMonkey(int n)
        {
            return n % 5 == 0;
        }

        private string Default(int number, string returnString)
        {
            return String.IsNullOrEmpty(returnString) ? number.ToString() : returnString;
        }
    }
}