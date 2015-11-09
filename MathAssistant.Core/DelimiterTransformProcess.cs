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
            var transformString = string.Empty;
            const int startSequenceNumber = 1;

            for (var number = startSequenceNumber; number <= sequenceNumber; number++)
            {
                if (number > startSequenceNumber)
                    transformString += delimiter;
                
                transformString += numericTransformer.Transform(number);
            }
         
            return transformString;
        }
    }
}