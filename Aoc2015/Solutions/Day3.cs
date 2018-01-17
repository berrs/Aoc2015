using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2015
{
    public static class Day3
    {
        static int XDiff(char c) => (c == '>' ? 1 : (c == '<' ? -1 : 0));
        static int YDiff(char c) => (c == '^' ? 1 : (c == 'v' ? -1 : 0));

        public static class A
        {
            public static int Calculate(string input)
            {
                var counters = new Dictionary<string, int>();
                int x = 0;
                int y = 0;
                string lastpos = "0.0";
                counters[lastpos] = 1;
                foreach (char c in input)
                {
                    x += XDiff(c);
                    y += YDiff(c);
                    string pos = $"{x}.{y}";
                    if (pos != lastpos)
                    {
                        counters[pos] = (counters.TryGetValue(pos, out int previous) ? previous : 0) + 1;
                    }
                }
                return counters.Count;
            }
        }
    }
}