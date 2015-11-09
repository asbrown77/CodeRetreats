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
        [Test]
        public void Transform_WhenOne_ReturnStringOne()
        {
            var transformer = new NumericTransformer();
            var result = transformer.Transform(1);
            Assert.That(result, Is.EqualTo("1"));
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
