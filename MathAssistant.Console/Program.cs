
using MathAssistant.Core;

namespace MathAssistant.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWrapper();
            var application = new MathAssistantApplicationFactory(console).Create();
            application.Start();
        }
    }
}
