namespace MathAssistant.Core
{
    public class MathAssistantApplication
    {
        private readonly IConsole console;

        public MathAssistantApplication(IConsole console)
        {
            this.console = console;
        }

        public void Start()
        {
            console.WriteLine("Enter Sequence Number:");
            console.ReadLine();

            console.WriteLine("Exit");
        }
    }
}