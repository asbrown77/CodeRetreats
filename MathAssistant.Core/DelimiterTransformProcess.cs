using MathAssistant.Core.Interfaces;

namespace MathAssistant.Core
{
    public class DelimiterTransformProcess
    {
        private readonly INumericTransformer numericTransformer;
        private readonly char delimiter;

        public DelimiterTransformProcess(INumericTransformer numericTransformer, char delimiter = ',')
        {
            this.numericTransformer = numericTransformer;
            this.delimiter = delimiter;
        }

        public string CreateTransformString(int sequenceNumber)
        {
            var transformString = "";
     
            for (var number = 1; number <= sequenceNumber; number++)
            {
                if (number > 1)
                    transformString += delimiter;
                
                transformString += numericTransformer.Transform(number);
            }
         
            return transformString;
        }
    }
}