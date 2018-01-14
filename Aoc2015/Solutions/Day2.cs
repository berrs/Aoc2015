using System;

namespace Aoc2015
{
    public class Day2a
    {
        public static int Calculate(int l, int w, int h)
        {
            int a1 = l * w;
            int a2 = w * h;
            int a3 = l * h;
            int min = Math.Min(Math.Min(a1, a2), a3);
            return 2*a1 + 2*a2 + 2*a3 + min;
        }

        public static int Calculate(string dimensions)
        {
            string[] parts = dimensions.Split('x');
            if (parts.Length == 3)
            {
                int l = Convert.ToInt32(parts[0]);
                int w = Convert.ToInt32(parts[1]);
                int h = Convert.ToInt32(parts[2]);
                return Calculate(l, w, h);
            }
            return 0;
        }
    }
}