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

            DisplayOutput(TransformInputSequenceNumberToStringFormat());

            ShuttingDown();
        }

        private string TransformInputSequenceNumberToStringFormat()
        {
            var transformString = "";
            if (InputIsNumericValue())
            {
                transformString = lastInput;
            }
            else
            {
                transformString = "Need to enter numeric value!";
            }
            return transformString;
        }

        private void PromptForSequenceNumber()
        {
            DisplayOutput("Enter Sequence Number:");
            lastInput = console.ReadLine();
        }

        private bool InputIsNumericValue()
        {
            int numericValue;
            return int.TryParse(lastInput, out numericValue);
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