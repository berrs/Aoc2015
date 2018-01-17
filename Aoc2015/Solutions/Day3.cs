using System.Collections.Generic;

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

            public static bool operator ==(Point a, Point b) => a.X == b.X && a.Y == b.Y;
            public static bool operator !=(Point a, Point b) => !(a == b);

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

        public static class B
        {
            public static int Calculate(string input)
            {
                var counters = new Dictionary<string, int>();
                var santa = new Point(0, 0);
                var robodog = new Point(0, 0);
                Increment(counters, santa);
                Increment(counters, robodog);

                var e = input.GetEnumerator();
                bool keepgoing = true;
                while (keepgoing)
                {
                    if (e.MoveNext())
                    {
                        var next = santa + e.Current;
                        if (next != santa)
                        {
                            santa = next;
                            Increment(counters, santa);
                        }
                    }

                    if (keepgoing = e.MoveNext())
                    {
                        var next = robodog + e.Current;
                        if (next != robodog)
                        {
                            robodog = next;
                            Increment(counters, robodog);
                        }
                    }
                }

                return counters.Count;
            }

            static void Increment(Dictionary<string, int> counters, Point p)
            {
                var pos = p.ToString();
                counters[pos] = (counters.TryGetValue(pos, out int previous) ? previous : 0) + 1;
            }
        }
    }
}