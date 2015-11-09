using System;
using MathAssistant.Core.Interfaces;
using MathAssistant.Core.TransformRules;

namespace MathAssistant.Core
{
    public class MathAssistantApplicationFactory
    {
        private readonly IConsole console;

        public MathAssistantApplicationFactory(IConsole console)
        {
            this.console = console;
        }
        public MathAssistantApplication Create()
        {
            INumericTransformer numericTransformer = new NumericTransformer(new FizzBuzzRule());
            return new MathAssistantApplication(console, numericTransformer);
        }
    }

    public class MathAssistantApplication
    {
        private readonly IConsole console;
        private string lastInput;
        private readonly DelimiterTransformProcess delimeterTransformProcess;

        internal MathAssistantApplication(IConsole console, INumericTransformer numericTransformer)
        {
            this.console = console;
            delimeterTransformProcess = new DelimiterTransformProcess(numericTransformer);
        }

        public void Start()
        {
            PromptForSequenceNumber();

            while (!IsExitInputValue())
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
                delimeterTransformProcess.CreateTransformString(sequenceNumber) 
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