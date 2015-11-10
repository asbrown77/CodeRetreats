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
                (n, s) =>
                {
                    if (n == 5)
                    {
                        return "Monkey";
                    }

                    return s;
                },
                (n, s) =>
                {
                    if(String.IsNullOrEmpty(s))
                        return n.ToString();
                    return s;
                }
            };
        }

    }
}