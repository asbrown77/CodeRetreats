using System;
using System.Collections.Generic;
using MathAssistant.Core.Interfaces;
using MathAssistant.Core.TransformRules;

namespace MathAssistant.Core
{
    public class NumericTransformer : INumericTransformer
    {
        private readonly IList<Func<int, string, string>> rules;

        public NumericTransformer()
        {
            rules = new FizzBuzzRule().Rules;
        }

        public string Transform(int number)
        {
            var returnString = String.Empty;

            foreach (var rule in rules)
            {
                returnString = rule(number, returnString);
            }

            return returnString;
        }
    }
}