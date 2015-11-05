using MathAssistant.Core;
using NUnit.Framework;
using Rhino.Mocks;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class MathAssistantTests
    {
        [Test]
        public void WhenStart_ShouldBePromptedToEnterSequenceNumber()
        {
            var console = MockRepository.GenerateMock<IConsole>();
            var application = new MathAssistantApplication(console);

            application.Start();

            console.AssertWasCalled(x => x.WriteLine("Enter Sequence Number:"), option => option.Repeat.Once());
        }

        [Test]
        public void WhenStart_ShouldWaitForResponse()
        {
            var console = MockRepository.GenerateMock<IConsole>();
            var application = new MathAssistantApplication(console);

            application.Start();

            console.AssertWasCalled(x => x.ReadLine(), options => options.Repeat.Once());
        }
    }
}
