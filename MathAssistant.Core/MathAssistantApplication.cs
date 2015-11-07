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

            if (IsValidNumericValue())
            {
                DisplayOutput("Need to enter numeric value!");
            }
            else
            {
                DisplayOutput(lastInput);
            }

            ShuttingDown();
        }

        private void PromptForSequenceNumber()
        {
            DisplayOutput("Enter Sequence Number:");
            lastInput = console.ReadLine();
        }

        private bool IsValidNumericValue()
        {
            return lastInput == "x";
        }

        private void DisplayOutput(string value)
        {
            console.WriteLine(value);
        }

        private void ShuttingDown()
        {
            DisplayOutput("Exit");
        }
    }
}