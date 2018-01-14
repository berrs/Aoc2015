using Xunit.Abstractions;

namespace Aoc2015.Tests
{
    public abstract class TestBase
    {
        readonly ITestOutputHelper output;
        protected TestBase(ITestOutputHelper output) => this.output = output;
        protected void WriteLine(object message) => output.WriteLine(message?.ToString());
    }
}