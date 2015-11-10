
using MathAssistant.Core;
using MathAssistant.Core.TransformRules;

namespace MathAssistant.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWrapper();
            var application = new MathAssistantApplicationFactory(console).Create(new FizzBuzzRule());
            application.Start();
        }
    }
}
