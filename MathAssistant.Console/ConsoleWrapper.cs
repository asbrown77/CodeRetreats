using MathAssistant.Core.Interfaces;

namespace MathAssistant.Console
{
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