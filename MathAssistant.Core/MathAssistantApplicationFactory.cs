using MathAssistant.Core.Interfaces;
using MathAssistant.Core.TransformRules;

namespace MathAssistant.Core
{
    public class MathAssistantApplicationFactory
    {
        private readonly IConsole console;

        public ITransformRule TransformRule { get; private set; }

        public MathAssistantApplicationFactory(IConsole console)
        {
            this.console = console;
        }
        
        public MathAssistantApplication Create(ITransformRule rule)
        {
            TransformRule = rule;
            INumericTransformer numericTransformer = new NumericTransformer(rule);
            return new MathAssistantApplication(console, numericTransformer);
        }

        public MathAssistantApplication Create(RuleEnum ruleType)
        {
            var transformRule = new FizzBuzzRule();
            if (ruleType == RuleEnum.Monkey)
            {
                transformRule = new MonkeyRule();
            }

            return Create(transformRule);
        }
    }
}