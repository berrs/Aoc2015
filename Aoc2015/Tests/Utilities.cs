using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2015.Tests
{
    static class Utilities
    {
        public static IEnumerable<string> Tokenize(this string input)
        {
            return (input ?? "")
                .Split('\n')
                .Select(s => s.Trim())
                .Where(s => !String.IsNullOrEmpty(s));
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> fn)
        {
            if (source != null && fn != null)
            {
                foreach (var x in source)
                {
                    fn(x);
                }
            }
        }
    }
}