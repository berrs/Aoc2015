using System;

namespace Aoc2015
{
    public class Day2
    {
        public class Size
        {
            public readonly int Length;
            public readonly int Width;
            public readonly int Height;

            public Size(int length, int width, int height)
            {
                Length = length;
                Width = width;
                Height = height;
            }

            public static Size Parse(string dimensions)
            {
                string[] parts = dimensions.Split('x');
                if (parts.Length == 3)
                {
                    int l = Convert.ToInt32(parts[0]);
                    int w = Convert.ToInt32(parts[1]);
                    int h = Convert.ToInt32(parts[2]);
                    return new Size(l, w, h);
                }
                return null;
            }
        }

        public class A
        {
            public static int Calculate(Size s)
            {
                if (s != null)
                {
                    int a1 = s.Length * s.Width;
                    int a2 = s.Width * s.Height;
                    int a3 = s.Length * s.Height;
                    int min = Math.Min(Math.Min(a1, a2), a3);

                    return 2*a1 + 2*a2 + 2*a3 + min;
                }

                return 0;
            }

            public static int Calculate(string dimensions)
            {
                return Calculate(Size.Parse(dimensions));
            }
        }

        public class B
        {
            public static int Calculate(string dimensions)
            {
                return Calculate(Size.Parse(dimensions));
            }

            static int Calculate(Size s)
            {
                if (s != null)
                {
                    int[] d = {s.Length, s.Width, s.Height};
                    Array.Sort(d);
                    return d[0] * 2 +
                           d[1] * 2 +
                           d[0] * d[1] * d[2];
                }

                return 0;
            }
        }
    }
}