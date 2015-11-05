using MathAssistant.Core;
using NUnit.Framework;
using Rhino.Mocks;

namespace MathAssistant.UnitTests
{
    [TestFixture]
    public class MathAssistantTests
    {
        [Test]
        public void WhenStart__ShouldBePromptedToEnterSequenceNumber()
        {
            var console = MockRepository.GenerateMock<IConsole>();
            var application = new MathAssistantApplication(console);

            application.Start();

            console.AssertWasCalled(x => x.WriteLine("Enter Sequence Number:"), option => option.Repeat.Once());
        }
    }
}
