using System;

namespace ConsoleApp1
{
    class SpiralMatrix
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[4,4]
            { { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 }, 
            { 13, 14, 15, 16 } };

            Console.WriteLine("Array elements are : ");

            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int Top = 0, Left = 0;
            int Bottom = rows-1, Right = cols-1;

            Console.WriteLine("Spiral form : ");

            while (Top<=Bottom && Left<=Right)
            {
                for(int i = Left;  i <= Right; i++)
                    Console.Write(arr[Top, i] + " ");
                Top++;
                
                for(int i = Top; i <= Bottom; i++)
                    Console.Write(arr[i, Right] + " ");
                Right--;

                if(Top<=Bottom)
                {
                    for(int i = Right; i >= Left; i--)
                        Console.Write(arr[Bottom, i] + " ");
                    Bottom--;
                }
                if (Left <= Right)
                {
                    for (int i = Bottom; i >= Top; i--)
                        Console.Write(arr[i, Left] + " ");
                    Left++;
                }
            }
            Console.ReadKey();
        }
    }
}
