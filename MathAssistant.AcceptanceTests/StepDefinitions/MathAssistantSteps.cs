using System;
using MathAssistant.Core;
using Rhino.Mocks;
using TechTalk.SpecFlow;

namespace MathAssistant.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class FizzBuzzTransformationSteps
    {
        private IConsole console;

        [Given(@"I prompted to enter the total number of sequence numbers")]
        public void GivenIPromptedToEnterTheTotalNumberOfSequenceNumbers()
        {
            console = MockRepository.GenerateMock<IConsole>();
            var mathAssistantApplication = new MathAssistantApplication(console);

            mathAssistantApplication.Start();
        }
        
        [When(@"I have entered in ""(.*)""")]
        public void WhenIHaveEnteredIn(string inputValue)
        {
            console.Stub(x => x.ReadLine()).Return(inputValue).Repeat.Once();
        }
        
        [Then(@"should exit application")]
        public void ThenShouldExitApplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
