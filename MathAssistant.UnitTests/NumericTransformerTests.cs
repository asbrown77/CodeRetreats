using MathAssistant.Core;
using NUnit.Framework;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class NumericTransformerTests
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(3,"Fizz")]
        [TestCase(5,"Buzz")]
        [TestCase(6,"Fizz")]
        public void Transform_WhenOne_ReturnStringOne(int number, string expectedString)
        {
            var transformer = new NumericTransformer();
            var result = transformer.Transform(number);
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
