using System;
using System.Data.Odbc;

namespace MathAssistant.Core
{
    public class MathAssistantApplication
    {
        private readonly IConsole console;
        private readonly NumericTransformer numericTransformer;
        private string lastInput;

        public MathAssistantApplication(IConsole console)
        {
            this.console = console;
            this.numericTransformer = new NumericTransformer();
        }

        public void Start()
        {
            PromptForSequenceNumber();

            if (!IsExitInputValue())
            {
                DisplayOutput(TransformInputSequenceNumberToStringFormat());
                PromptForSequenceNumber();
            }

            ShuttingDown();
        }

        private bool IsExitInputValue()
        {
            return (String.IsNullOrEmpty(lastInput) || lastInput == "0");
        }

        private string TransformInputSequenceNumberToStringFormat()
        {
            int sequenceNumber;
            return InputIsNumericValue(out sequenceNumber) ? CreateDelimiterTransformString(sequenceNumber) : "Need to enter numeric value!";
        }

        private string CreateDelimiterTransformString(int sequenceNumber)
        {
            var transformString = "";
            if (sequenceNumber > 1)
            {
                transformString = "1,";
            }
            transformString += numericTransformer.Transform(sequenceNumber);
            return transformString;
        }

        private void PromptForSequenceNumber()
        {
            DisplayOutput("Enter Sequence Number:");
            lastInput = console.ReadLine();
        }

        private bool InputIsNumericValue(out int numericValue)
        {
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