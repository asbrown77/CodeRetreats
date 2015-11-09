using System;
using MathAssistant.Core.Interfaces;
using MathAssistant.Core.TransformRules;

namespace MathAssistant.Core
{
    public class MathAssistantApplication
    {
        private readonly IConsole console;
        private string lastInput;
        private readonly DelimiterTransformProcess delimeterTransforProcess;

        public MathAssistantApplication(IConsole console)
        {
            this.console = console;
            var numericTransformer = new NumericTransformer(new FizzBuzzRule());
            this.delimeterTransforProcess = new DelimiterTransformProcess(numericTransformer);
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
            return InputIsNumericValue(out sequenceNumber) ? 
                delimeterTransforProcess.CreateTransformString(sequenceNumber) 
                : "Need to enter numeric value!";
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