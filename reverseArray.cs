using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, 6, 2, 1, 12, 7 };
            int n = arr.Length;
            int[] temp = new int[n];
            int x = 0, y = n - 1;
            for (int i = 0; i < n; i++)
            {
                temp[y] = arr[x];
                x++;
                y--;
            }
            foreach (int a in temp)
            {
                Console.Write(a + " ");
            }   
        }
    }
}
