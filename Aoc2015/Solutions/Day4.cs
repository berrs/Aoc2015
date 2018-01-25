using System;
using System.Security.Cryptography;
using System.Text;

namespace Aoc2015
{
    public static class Day4
    {
        static int Calculate(string input, Predicate<byte[]> done)
        {
            var md5 = MD5.Create();
            int i = 1;
            for (; ; i++)
            {
                var data = Encoding.ASCII.GetBytes(input + i);
                byte[] hash = md5.ComputeHash(data);
                if (done(hash))
                {
                    break;
                }
            }
            return i;
        }

        public static class A
        {
            public static int Calculate(string input)
            {
                return Day4.Calculate(input, h => h[0] == 0 && 
                                                  h[1] == 0 && 
                                                  h[2] < 0x10);
            }
        }

        public static class B
        {
            public static long Calculate(string input)
            {
                return Day4.Calculate(input, h => h[0] == 0 && 
                                                  h[1] == 0 && 
                                                  h[2] == 0);
            }
        }
    }
}