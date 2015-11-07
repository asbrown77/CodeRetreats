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
            var input = console.ReadLine();

            if (input == "x")
            {
                console.WriteLine("Need to enter numeric value!");
            }

            console.WriteLine("Exit");
        }
    }
}