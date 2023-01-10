namespace Codemash.TDD.Fizzbuzz
{
    public class FizzBuzzService
    {
        public FizzBuzzService()
        {

        }

        public List<string> GenerateValues(int quantity = 100)
        {
            var fizzBuzzResult = new List<string>();

            for (int i = 1; i < quantity; i++)
                fizzBuzzResult.Add(ProcessValue(i));

            return fizzBuzzResult;
        }

        private string ProcessValue(int value)
        {
            var isDivisibleBy3 = value % 3 == 0;
            var isDivisibleBy5 = value % 5 == 0;

            if (isDivisibleBy3 && isDivisibleBy5)
                return "FizzBuzz";
            if (isDivisibleBy3)
                return "Fizz";
            if (isDivisibleBy5)
                return "Buzz";

            return value.ToString();
        }
    }
}