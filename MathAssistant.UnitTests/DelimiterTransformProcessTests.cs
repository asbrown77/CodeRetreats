using MathAssistant.Core;
using NUnit.Framework;
using Rhino.Mocks;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class DelimiterTransformProcessTests
    {
        private static INumericTransformer MakeDummyTransformerIntegerToString()
        {
            var numericTransformer = MockRepository.GenerateStub<INumericTransformer>();
            numericTransformer.Stub(x => x.Transform(Arg<int>.Is.Anything))
                .Return(null)
                .WhenCalled(r =>
                {
                    var returnString = r.Arguments[0].ToString();
                    r.ReturnValue = returnString;
                });
            return numericTransformer;
        }

        [TestCase(1, "1")]
        [TestCase(2, "1,2")]
        [TestCase(3, "1,2,3")]
        public void CreateTransformString_WhenSquenceNumber_ReturnExpectedString(int sequenceNumber, string expectedString)
        {
            var numericTransformer = MakeDummyTransformerIntegerToString();

            var delimiterTransformProcess = new DelimiterTransformProcess(numericTransformer);
            var result = delimiterTransformProcess.CreateTransformString(sequenceNumber);

            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
