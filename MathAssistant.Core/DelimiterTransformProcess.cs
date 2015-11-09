namespace MathAssistant.Core
{
    public class DelimiterTransformProcess
    {
        private readonly INumericTransformer numericTransformer;

        public DelimiterTransformProcess(INumericTransformer numericTransformer)
        {
            this.numericTransformer = numericTransformer;
        }

        public string CreateTransformString(int sequenceNumber)
        {
            var transformString = "";
            for (var number = 1; number <= sequenceNumber; number++)
            {
                if (number > 1)
                {
                    transformString += ",";
                }
                transformString += numericTransformer.Transform(number);
            }
         
            return transformString;
        }
    }
}