using Xunit;
using Xunit.Abstractions;

namespace Aoc2015.Tests
{
    public class Day1bTests : TestBase
    {
        public Day1bTests(ITestOutputHelper output) : base(output) { }

        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        public void Spec(string input, int expected)
        {
            Assert.Equal(expected, Day1b.Calculate(input));
        }


        [Fact]
        public void CalculateDay1b()
        {
            WriteLine(Day1b.Calculate(Day1aTests.InputA).ToString());
        }
    }
}