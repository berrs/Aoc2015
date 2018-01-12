using System.Collections.Generic;
using System.Linq;

namespace Aoc2015
{
    public class Day1a
    {
        public static int Calculate(string input)
        {
            return input.Count(c => c == '(') - input.Count(c => c == ')');
        }
    }

    public class Day1b
    {
        static int ValueOf(char c)
        {
            if (c == '(') return 1;
            if (c == ')') return -1;
            return 0;
        }

        static IEnumerable<int> GetFloors(string input)
        {
            int floor = 0;
            return input.Select(ValueOf).Select(x => { floor += x; return floor; });
        }

        public static int Calculate(string input)
        {
            return GetFloors(input).TakeWhile(x => x >= 0).Count() + 1;
        }
    }
}