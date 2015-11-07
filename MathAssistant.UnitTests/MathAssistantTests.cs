using MathAssistant.Core;
using NUnit.Framework;
using Rhino.Mocks;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class MathAssistantTests
    {
        private IConsole console;
        private MathAssistantApplication application;

        private void VerifyOutput(string value)
        {
            console.AssertWasCalled(x => x.WriteLine(value), option => option.Repeat.Once());
        }

        [SetUp]
        public void Setup()
        {
            console = MockRepository.GenerateMock<IConsole>();
            application = new MathAssistantApplication(console);
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
    }
}
