namespace MathAssistant.Core
{
    public class DelimeterTransforProcess
    {
        private readonly NumericTransformer numericTransformer;

        public DelimeterTransforProcess(NumericTransformer numericTransformer)
        {
            this.numericTransformer = numericTransformer;
        }

        public string CreateDelimiterTransformString(int sequenceNumber)
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