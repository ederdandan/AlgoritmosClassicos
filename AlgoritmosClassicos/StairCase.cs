using System;
using System.Linq;

namespace AlgoritmosClassicos
{
    public static class StairCase
    {
        public static void Run(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var result = (String.Concat(Enumerable.Repeat(" ", n)) + String.Concat(Enumerable.Repeat("#", i)));
                Console.WriteLine(result.Substring(result.Length - n));
            }
        }
    }
}
