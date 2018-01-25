using System.Security.Cryptography;
using System.Text;

namespace Aoc2015
{
    public static class Day4
    {
        public static class A
        {
            public static int Calculate(string input)
            {
                var md5 = MD5.Create();
                int i = 1;
                for (; ; i++)
                {
                    var data = Encoding.ASCII.GetBytes(input + i);
                    byte[] hash = md5.ComputeHash(data);
                    if (hash[0] == 0 && hash[1] == 0 && hash[2] < 0x10)
                    {
                        break;
                    }
                }
                return i;
            }
        }

        public static class B
        {
            public static long Calculate(string input)
            {
                var md5 = MD5.Create();
                long i = 1;
                for (; ; i++)
                {
                    var data = Encoding.ASCII.GetBytes(input + i);
                    byte[] hash = md5.ComputeHash(data);
                    if (hash[0] == 0 && hash[1] == 0 && hash[2] == 0)
                    {
                        break;
                    }
                }
                return i;
            }
        }
    }
}