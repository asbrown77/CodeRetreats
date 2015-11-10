using System;
using MathAssistant.Core;
using MathAssistant.Core.Interfaces;
using MathAssistant.Core.TransformRules;
using Rhino.Mocks;
using TechTalk.SpecFlow;

namespace MathAssistant.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class MathAssistantSteps
    {
        private IConsole console;
        private MathAssistantApplication mathAssistantApplication;
        
        private void EnterInputValue(string inputValue)
        {
            console.Stub(x => x.ReadLine()).Return(inputValue).Repeat.Once();
        }

        private void VerifyOutput(string value, int numberOfTimes = 1)
        {
            console.AssertWasCalled(x => x.WriteLine(value), options => options.Repeat.Times(numberOfTimes));
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            console = MockRepository.GenerateMock<IConsole>(); 
        }

        [Given(@"I have Transformation Rule of ""(.*)""")]
        public void GivenIHaveTransformationRuleOf(string ruleType)
        {
        }

        [Given(@"I prompted to enter the total number of sequence numbers")]
        public void GivenIPromptedToEnterTheTotalNumberOfSequenceNumbers()
        {
            var applicationFactory = new MathAssistantApplicationFactory(console);
           
            mathAssistantApplication = applicationFactory.Create();
        }

        [Given(@"I have entered in ""(.*)""")]
        public void GivenIHaveEnteredIn(string inputValue)
        {
            EnterInputValue(inputValue);
        }

        [When(@"I have entered in ""(.*)""")]
        public void WhenIHaveEnteredIn(string inputValue)
        {
            EnterInputValue(inputValue);
            mathAssistantApplication.Start();
        }

        [Then(@"should exit application")]
        public void ThenShouldExitApplication()
        {
            VerifyOutput("Exit");
        }

        [Then(@"I should display ""(.*)""")]
        public void ThenIShouldDisplay(string value)
        {
            VerifyOutput(value);
        }

        [Then(@"I should prompted to enter another sequence number")]
        public void ThenIShouldPromptedToEnterAnotherSequenceNumber()
        {
            VerifyOutput("Enter Sequence Number:", 2);
        }
    }
}
