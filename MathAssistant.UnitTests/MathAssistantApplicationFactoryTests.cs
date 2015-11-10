using MathAssistant.Core;
using MathAssistant.Core.TransformRules;
using NUnit.Framework;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class MathAssistantApplicationFactoryTests
    {
        [Test]
        public void Create_WhenFizzBuzz_ReturnFizzBuzzTransformRule()
        {
            var factory = new MathAssistantApplicationFactory(null);
            var ruleTransform = factory.Create(RuleEnum.FizzBuzz);
            Assert.That(ruleTransform, Is.TypeOf<FizzBuzzRule>());
        }
    }
}
