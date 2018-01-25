using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace Aoc2015.Tests.Day4Tests
{
    public class Day4aTests : TestBase
    {
        public Day4aTests(ITestOutputHelper output) : base(output) { }

        [Theory]
        [InlineData("abcdef", 609043)]
        [InlineData("pqrstuv", 1048970)]
        public void Spec(string input, int expected)
        {
            var sw = Stopwatch.StartNew();
            Day4.A.Calculate(input).ShouldEqual(expected);
            WriteLine(sw.Elapsed);
        }

        [Fact]
        public void Run()
        {
            var sw = Stopwatch.StartNew();
            WriteLine(Day4.A.Calculate("bgvyzdsv"));
            WriteLine(sw.Elapsed);
        }
    }

    public class Day4bTests : TestBase
    {
        public Day4bTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void Run()
        {
            var sw = Stopwatch.StartNew();
            WriteLine(Day4.B.Calculate("bgvyzdsv"));
            WriteLine(sw.Elapsed);
        }
    }
}