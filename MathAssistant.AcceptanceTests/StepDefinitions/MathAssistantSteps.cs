using System;
using MathAssistant.Core;
using Rhino.Mocks;
using TechTalk.SpecFlow;

namespace MathAssistant.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class MathAssistantSteps
    {
        private IConsole console;

        private void EnterInputValue(string inputValue)
        {
            console.Stub(x => x.ReadLine()).Return(inputValue).Repeat.Once();
        }

        private void VerifyOutput(string value)
        {
            console.AssertWasCalled(x => x.WriteLine(value));
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            console = MockRepository.GenerateMock<IConsole>();     
        }

        [Given(@"I prompted to enter the total number of sequence numbers")]
        public void GivenIPromptedToEnterTheTotalNumberOfSequenceNumbers()
        {
            var mathAssistantApplication = new MathAssistantApplication(console);
            mathAssistantApplication.Start();
        }
        
        [When(@"I have entered in ""(.*)""")]
        public void WhenIHaveEnteredIn(string inputValue)
        {
            EnterInputValue(inputValue);
        }

        [Then(@"should exit application")]
        public void ThenShouldExitApplication()
        {
            VerifyOutput("Exit");
        }
    }
}
