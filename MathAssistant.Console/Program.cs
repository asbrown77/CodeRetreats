
using MathAssistant.Core;
using MathAssistant.Core.Interfaces;
using MathAssistant.Core.TransformRules;

namespace MathAssistant.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWrapper();
            var numericTransformer = new NumericTransformer(new FizzBuzzRule());
            var application = new MathAssistantApplication(console, numericTransformer);

            application.Start();
        }
    }

    public class ConsoleWrapper : IConsole
    {
        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
