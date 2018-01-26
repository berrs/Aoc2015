using System.Linq;
using System.Text.RegularExpressions;

namespace Aoc2015
{
    public static class Day5
    {
        public static class A
        {
            static readonly Regex Rule1 = new Regex(@"[aeiou].*[aeiou].*[aeiou]");
            static readonly Regex Rule2 = new Regex(@"(.)\1");
            static readonly Regex Rule3 = new Regex(@"(ab|cd|pq|xy)");
            
            public static bool Calculate(string input)
            {
                return Rule1.IsMatch(input) &&
                       Rule2.IsMatch(input) &&
                       !Rule3.IsMatch(input);
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