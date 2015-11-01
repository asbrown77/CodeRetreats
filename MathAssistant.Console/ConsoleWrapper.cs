using MathAssistant.Core;

namespace MathAssistant.Console
{
    public class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }
    }
}