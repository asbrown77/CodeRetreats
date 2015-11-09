namespace MathAssistant.Core
{
    public class NumericTransformer : INumericTransformer
    {
        public string Transform(int number)
        {
            string returnString = number.ToString(); ;

            if (IsFizz(number))
                returnString = "Fizz";

            return returnString;
        }

        private static bool IsFizz(int number)
        {
            return number == 3;
        }
    }
}