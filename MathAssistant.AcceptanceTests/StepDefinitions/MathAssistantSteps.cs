using System;
using Rhino.Mocks;
using TechTalk.SpecFlow;

namespace MathAssistant.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class FizzBuzzTransformationSteps
    {
        [Given(@"I prompted to enter the total number of sequence numbers")]
        public void GivenIPromptedToEnterTheTotalNumberOfSequenceNumbers()
        {
            var console = MockRepository.GenerateMock<IConsole>();
            var mathAssistantApplication = new MathAssistantApplication(console);

            mathAssistantApplication.Start();
        }
        
        [When(@"I have entered in ""(.*)""")]
        public void WhenIHaveEnteredIn(string inputValue)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"should exit application")]
        public void ThenShouldExitApplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
