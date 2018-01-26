using System.Text.RegularExpressions;

namespace Aoc2015
{
    public static class Day5
    {
        public static class A
        {
            public static bool Calculate(string input)
            {
                int v = 3;
                bool dd = false;

                char p = '\0';
                int n = input.Length;
                for (int i = 0; i < n; i++)
                {
                    char c = input[i];

                    if (v > 0 && (c == 'a' || c == 'e' || c == 'i' || c == 'u'))
                    {
                        v--;
                    }

                    dd = dd || c == p;

                    bool bad = ((p == 'a' && c == 'b') ||
                                (p == 'c' && c == 'd') ||
                                (p == 'p' && c == 'q') ||
                                (p == 'x' && c == 'y'));
                    if (bad)
                    {
                        return false;
                    }

                    p = c;
                }

                return v == 0 && dd;
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