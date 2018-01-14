using Xunit;

namespace Aoc2015.Tests
{
    static class FluentAssertions
    {
        public static void ShouldEqual<T>(this T actual, T expected) => Assert.Equal(expected, actual);
    }
}