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
                int c1 = 0;
                bool r1 = false, r2 = false, r3 = false;

                int n = input.Length - 1;
                for (int i = 0; !r3 && i <= n; i++)
                {
                    char c = input[i];

                    if (!r1 && "aeiou".IndexOf(c) >= 0)
                    {
                        c1 += 1;
                        r1 = c1 >= 3;
                    }

                    if (i < n)
                    {
                        char d = input[i + 1];
                        r2 = r2 || d == c;
                        r3 = ((c == 'a' && d == 'b') ||
                              (c == 'c' && d == 'd') ||
                              (c == 'p' && d == 'q') ||
                              (c == 'x' && d == 'y'));
                    }
                }

                return r1 && r2 && !r3;
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