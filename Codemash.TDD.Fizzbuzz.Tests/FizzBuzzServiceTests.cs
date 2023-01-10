using Xunit;

namespace Codemash.TDD.Fizzbuzz.Tests
{
    public class FizzBuzzServiceTests
    {
        [Fact]
        public void GenerateShouldHaveFizzFor3Diviser()
        {
            var fbService = new FizzBuzzService();
            var values = fbService.GenerateValues();

            var three = values[2];
            var six = values[5];
            var nine = values[8];
            var twelve = values[11];
            var fifteen = values[14];

            Assert.Equal("Fizz", three);
            Assert.Equal("Fizz", six);
            Assert.Equal("Fizz", nine);
            Assert.Equal("Fizz", twelve);

            Assert.NotEqual("Fizz", fifteen);
        }

        [Fact]
        public void GenerateShouldHaveFizzFor5Diviser()
        {
            var fbService = new FizzBuzzService();
            var values = fbService.GenerateValues();

            var five = values[4];
            var ten = values[9];
            var fifteen = values[14];
            var twenty = values[19];
            var twentyfive = values[24];

            Assert.Equal("Buzz", five);
            Assert.Equal("Buzz", ten);
            Assert.Equal("Buzz", twenty);
            Assert.Equal("Buzz", twentyfive);

            Assert.NotEqual("Buzz", fifteen);
        }

        [Fact]
        public void GenerateShouldHaveFizzFor3and5Divisers()
        {
            var fbService = new FizzBuzzService();
            var values = fbService.GenerateValues();

            var fifteen = values[14];
            var thirty = values[29];
            var fortyfive = values[44];
            var sixty = values[59];

            Assert.Equal("FizzBuzz", fifteen);
            Assert.Equal("FizzBuzz", thirty);
            Assert.Equal("FizzBuzz", fortyfive);
            Assert.Equal("FizzBuzz", sixty);
        }
    }
}