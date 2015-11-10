using System;
using System.Collections.Generic;
using MathAssistant.Core.Interfaces;

namespace MathAssistant.Core.TransformRules
{
    public class MonkeyRule : ITransformRule
    {
        public IList<Func<int, string, string>> Rules { get; private set; }
    }
}