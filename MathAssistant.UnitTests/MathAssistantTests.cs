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
            console.AssertWasCalled(x => x.WriteLine("Enter Sequence Number:"), option => option.Repeat.Once());
        }

        [Test]
        public void WhenStart_ShouldWaitForResponse()
        {
            application.Start();
            console.AssertWasCalled(x => x.ReadLine(), options => options.Repeat.Once());
        }

        [Test]
        public void EnterInput_WhenStartedAndValueIsZero_ShouldExitApplication()
        {
            application.Start(); 
            console.AssertWasCalled(x => x.WriteLine("Exit"), option => option.Repeat.Once());
        }
    }
}
