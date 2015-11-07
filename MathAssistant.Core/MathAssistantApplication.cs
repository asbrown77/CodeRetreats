namespace MathAssistant.Core
{
    public class MathAssistantApplication
    {
        private readonly IConsole console;
        private string lastInput;

        public MathAssistantApplication(IConsole console)
        {
            this.console = console;
        }

        public void Start()
        {
            PromptForSequenceNumber();

            if (lastInput == "x")
            {
                DisplayOutput("Need to enter numeric value!");
            }
            else
            {
                DisplayOutput(lastInput);
            }

            DisplayOutput("Exit");
        }

        private void PromptForSequenceNumber()
        {
            DisplayOutput("Enter Sequence Number:");
            lastInput = console.ReadLine();
        }

        private void DisplayOutput(string value)
        {
            console.WriteLine(value);
        }
    }
}