using System.Linq;

namespace Aoc2015.Tests
{
    public class Day1a
    {
        public static int Calculate(string input)
        {
            return input.Count(c => c == '(') - input.Count(c => c == ')');
        }
    }
}