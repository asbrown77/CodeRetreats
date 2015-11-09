using MathAssistant.Core;
using NUnit.Framework;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class DelimiterTransformProcessTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "1,2")]
        public void CreateTransformString_WhenSquenceNumber_ReturnExpectedString(int sequenceNumber, string expectedString)
        {
            var delimiterTransformProcess = new DelimiterTransformProcess(new NumericTransformer());
            var result = delimiterTransformProcess.CreateTransformString(sequenceNumber);

            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
