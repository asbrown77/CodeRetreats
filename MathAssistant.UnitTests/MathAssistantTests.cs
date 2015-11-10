using MathAssistant.Core;
using MathAssistant.Core.Interfaces;
using NUnit.Framework;
using Rhino.Mocks;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class MathAssistantTests
    {
        public MathAssistantTests(string ruleType1)
        {
            ruleType = ruleType;
        }

        private IConsole console;
        private MathAssistantApplication application;
        private string ruleType;

        private void VerifyOutput(string value, int numberOfTimes = 1)
        {
            console.AssertWasCalled(x => x.WriteLine(value), option => option.Repeat.Times(numberOfTimes));
        }

        [SetUp]
        public void Setup()
        {
            console = MockRepository.GenerateMock<IConsole>();

            var applicationFactory = new MathAssistantApplicationFactory(console);
            application = applicationFactory.Create(MockRepository.GenerateStub<ITransformRule>());
        }

        private void MockEnteringInputValue(string inputValue)
        {
            console.Stub(x => x.ReadLine()).Return(inputValue).Repeat.Once();
        }

        [Test]
        public void WhenStart_ShouldBePromptedToEnterSequenceNumber()
        {
            application.Start();
            VerifyOutput("Enter Sequence Number:");
        }

        [Test]
        public void WhenStart_ShouldWaitForResponse()
        {
            application.Start();
            console.AssertWasCalled(x => x.ReadLine(), options => options.Repeat.Once());
        }

        [TestCase("0")]
        [TestCase("")]
        public void EnterInput_WhenStartedAndExitValue_ShouldExitApplication(string inputValue)
        {
            MockEnteringInputValue(inputValue);
            application.Start();
            VerifyOutput("Exit");
        }

        [TestCase("x", "Need to enter numeric value!")]
        [TestCase("xy", "Need to enter numeric value!")]
        public void EnterInput_WhenStartedAndInputValue_DisplayTheExpectedOutput(string inputValue, string expectedDisplayOutput)
         {
            MockEnteringInputValue(inputValue);
            application.Start();
            VerifyOutput(expectedDisplayOutput);
            VerifyOutput("Enter Sequence Number:", 2);
        }

        [Test]
        public void EnterInput_WhenPreviousSubmittedSequenceNumber_RequestForAnotherSeqenceNumber()
        {
            MockEnteringInputValue("1");
            MockEnteringInputValue("5");
            application.Start();
            VerifyOutput("Enter Sequence Number:", 3);
        }
    }
}
