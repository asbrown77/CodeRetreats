using System;
using System.Collections.Generic;
using MathAssistant.Core.Interfaces;

namespace MathAssistant.Core
{
    public class NumericTransformer : INumericTransformer
    {
        private readonly IList<Func<int, string, string>> rules;

        public NumericTransformer(ITransformRule transformRule)
        {
            rules = transformRule.Rules;
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