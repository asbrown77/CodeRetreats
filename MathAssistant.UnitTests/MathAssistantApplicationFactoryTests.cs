using System;
using MathAssistant.Core;
using MathAssistant.Core.TransformRules;
using NUnit.Framework;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class MathAssistantApplicationFactoryTests
    {
        [TestCase(RuleEnum.FizzBuzz, typeof(FizzBuzzRule))]
        [TestCase(RuleEnum.Monkey, typeof(MonkeyRule))]
        public void Create_WhenRuleType_ShouldUseExpectedTransformRule(RuleEnum ruleType, Type expectedTansformRuletype)
        {
            var factory = new MathAssistantApplicationFactory(null);
            var application = factory.Create(ruleType);

            Assert.IsNotNull(application);
            Assert.That(factory.TransformRule.GetType(), Is.EqualTo(expectedTansformRuletype));
        }


    }
}
