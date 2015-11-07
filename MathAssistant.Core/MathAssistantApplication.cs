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
            DisplayOutput("Enter Sequence Number:");
            var input = console.ReadLine();

            if (input == "x")
            {
                DisplayOutput("Need to enter numeric value!");
            }

            DisplayOutput("Exit");
        }

        private void DisplayOutput(string value)
        {
            console.WriteLine(value);
        }
    }
}