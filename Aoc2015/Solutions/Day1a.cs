using System.Collections.Generic;
using System.Linq;

namespace Aoc2015.Tests
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
        static IEnumerable<int> GetFloors(string input)
        {
            int floor = 0;
            foreach (char c in input)
            {
                if (c == '(')
                    floor++;
                else if (c == ')')
                    floor--;
                yield return floor;
            }
        }

        public static int Calculate(string input)
        {
            return GetFloors(input).TakeWhile(x => x >= 0).Count() + 1;
        }
    }
}