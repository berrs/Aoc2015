using System.Linq;
using System.Text.RegularExpressions;

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

        public static class B
        {
            public static Regex Rule1 = new Regex(@"(..).*\1", RegexOptions.Compiled);
            public static Regex Rule2 = new Regex(@"(.).\1", RegexOptions.Compiled);

            public static bool Calculate(string input)
            {
                return Rule1.IsMatch(input) && Rule2.IsMatch(input);
            }
        }
    }
}