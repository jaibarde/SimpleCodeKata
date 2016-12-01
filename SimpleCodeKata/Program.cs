using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LeastRecentlyUsedList lruObj1 = new LeastRecentlyUsedList();
            lruObj1.Add("a");
            lruObj1.Add("a");
            lruObj1.Add("b");
            lruObj1.Add("c");
            lruObj1.Add("a");
            lruObj1.Add("c");
            Console.WriteLine("Implementation #1 : " + lruObj1 + " Count : " + lruObj1.Count);
            Console.WriteLine("Element @ #2 : " + lruObj1[2]);
        }
    }

    public static class EnumerableOfStringExtensions
    {
        public static string ToCommaSeparatedList(this IEnumerable<string> input)
        {
            return string.Join(", ", input);
        }
    }
}