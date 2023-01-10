using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codemash.TDD.Fizzbuzz
{
    public class StringKataCalculator
    {
        public int GetCalledCount = 0;

        public int Add(string? numbers, string delimiter = ",")
        {
            GetCalledCount++;
            var splitNumbers = numbers?.Split(delimiter);
            var sum = splitNumbers?.Select(n => ValidateStringNumber(n)).Sum();
            return (int)(sum == null ? 0 : sum);
        }

        public int ValidateStringNumber(string? number)
        {
            if (string.IsNullOrEmpty(number) || number == "0")
                return 0;

            int parsedInt;
            var isValidInteger = int.TryParse(number, out parsedInt);
            if (!isValidInteger) throw new ArgumentException("Must use valid integers");
            if (parsedInt < 0) throw new ArgumentException($"Negatives Not Allowed: {parsedInt}");
            if (parsedInt > 1000) return 0;
            if (isValidInteger) return parsedInt;

            return 0;
        }
    }
}
