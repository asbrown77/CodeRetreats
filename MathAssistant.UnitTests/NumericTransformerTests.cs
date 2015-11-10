using MathAssistant.Core;
using MathAssistant.Core.TransformRules;
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
        [TestCase(10,"Buzz")]
        [TestCase(15,"FizzBuzz")]
        public void Transform_WhenNumberAndFizzBuzzRule_ReturnExpectedString(int number, string expectedString)
        {
            var transformer = new NumericTransformer(new FizzBuzzRule());
            var result = transformer.Transform(number);
            Assert.That(result, Is.EqualTo(expectedString));
        }

        [TestCase(1, "1")]
        public void Transform_WhenNumberAndMonkeyRule_ReturnExpectedString(int number, string expectedString)
        {
            var transformer = new NumericTransformer(new MonkeyRule());
            var result = transformer.Transform(number);
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}
