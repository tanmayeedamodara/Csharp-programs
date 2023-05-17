using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {7, 8, 9, 9, 8};
        Console.WriteLine("Given array: ");
        foreach(int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        BubbleSort(arr);
    }
    public static void BubbleSort(int[] a)
    {
        for(int i=0; i<a.Length-1; i++)
        {
            bool flag = false;
            for(int j=0; j<a.Length-1-i; j++)
            {
                if(a[j] > a[j+1])
                {
                    int temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;
                    flag = true;
                }
            }
            if(!flag)
            {
                break;
            }
        }
        
        Console.WriteLine("Sorted array: ");
        foreach(int element in a)
        {
            Console.Write(element + " ");
        }
    }
}
