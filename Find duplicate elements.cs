using System;
using Sy

namespace ConsoleApp1
{
    class FindDuplicateElements
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, 3, 4, 2, 2, 5, 5, 5, 3, 5 };
            Dictionary<int, int> dup = new Dictionary<int, int>();

            foreach(int a in arr)
            {
                if(dup.ContainsKey(a))
                {
                    dup[a]++;
                }
                else
                {
                    dup[a] = 1;
                }
            }
            int noOfDupElements = 0;
            foreach(KeyValuePair<int, int> num in dup)
            {
                if (num.Value > 1)
                {
                    Console.WriteLine($"Element {num.Key} occurs {num.Value}");
                    noOfDupElements++;
                }
            }
            Console.WriteLine($"No. of duplicate elements {noOfDupElements}");

            Console.ReadLine();
        }
    }
}
