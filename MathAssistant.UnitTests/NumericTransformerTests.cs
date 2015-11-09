using NUnit.Framework;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class NumericTransformerTests
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(3,"Fizz")]
        public void Transform_WhenOne_ReturnStringOne(int number, string expectedString)
        {
            var transformer = new NumericTransformer();
            var result = transformer.Transform(number);
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }

    public class NumericTransformer
    {
        public string Transform(int number)
        {
            var returnString = number.ToString();
            return returnString;
        }
    }
}
