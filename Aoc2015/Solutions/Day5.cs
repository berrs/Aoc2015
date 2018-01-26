using System.Linq;

namespace Aoc2015
{
    public static class Day5
    {
        public static class A
        {
            public static bool Calculate(string input)
            {
                return input.Count(c => "aeiou".Contains(c)) >= 3 &&
                       input.Any(c => input.Contains($"{c}{c}")) &&
                       !input.Contains("ab") &&
                       !input.Contains("cd") &&
                       !input.Contains("pq") &&
                       !input.Contains("xy");
            }
        }
    }
}