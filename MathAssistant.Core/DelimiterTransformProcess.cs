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
            if (sequenceNumber > 1)
            {
                transformString = "1,";
            }
            transformString += numericTransformer.Transform(sequenceNumber);
            return transformString;
        }
    }
}