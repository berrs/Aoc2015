﻿using System.Collections.Generic;

namespace Aoc2015
{
    public static class Day3
    {
        struct Point
        {
            int X, Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Point operator +(Point p, char c)
            {
                return new Point(p.X + XDiff(c), p.Y + YDiff(c));
            }

            public override string ToString()
            {
                return $"{X}.{Y}";
            }

            static int XDiff(char c) => Diff(c, '>', '<');
            static int YDiff(char c) => Diff(c, '^', 'v');
            static int Diff(char c, char pos, char minus) => (c == pos ? 1 : (c == minus ? -1 : 0));
        }

        public static class A
        {
            public static int Calculate(string input)
            {
                var counters = new Dictionary<string, int>();
                var p = new Point(0, 0);
                string lastpos = p.ToString();
                counters[lastpos] = 1;
                foreach (char c in input)
                {
                    p = p + c;
                    string pos = p.ToString();
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