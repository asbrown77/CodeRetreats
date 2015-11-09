using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class NumericTransformerTests
    {
        [TestCase(1,"1")]
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
            return "1";
        }
    }
}
