using System;
using TechTalk.SpecFlow;

namespace MathAssistant.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class FizzBuzzTransformationSteps
    {
        [Given(@"I prompted to enter the total number of sequence numbers")]
        public void GivenIPromptedToEnterTheTotalNumberOfSequenceNumbers()
        {
            ScenarioContext.Current.Pending();
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
