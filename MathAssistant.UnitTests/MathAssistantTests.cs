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

        //EnterInput_WhenStartedAndExitInputValueEntered_DontRequestForAnotherSeqenceNumber

        [TestCase(0)]
        public void EnterInput_WhenStartedAndHasInputValue_ShouldExitApplication(string inputValue)
        {
            application.Start();
            console.Stub(x => x.ReadLine()).Return(inputValue).Repeat.Once();
            VerifyOutput("Exit");
        }
    }
}
