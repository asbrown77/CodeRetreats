using System;
using System.Collections.Generic;

namespace MathAssistant.Core.Interfaces
{
    public interface ITransformRule
    {
        IList<Func<int, string, string>> Rules { get; }   
    }
}