namespace MathAssistant.Core
{
    public class DelimiterTransformProcess
    {
        private readonly NumericTransformer numericTransformer;

        public DelimiterTransformProcess(NumericTransformer numericTransformer)
        {
            this.numericTransformer = numericTransformer;
        }

        public string CreateTransformString(int sequenceNumber)
        {
            var transformString = "";
            if (sequenceNumber > 1)
            {
                transformString = "1,";
            }
            transformString += numericTransformer.Transform(sequenceNumber);
            return transformString;
        }
    }
}