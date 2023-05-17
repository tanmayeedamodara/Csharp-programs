using System;

public class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string result = reverseString(str);
        Console.WriteLine ("Original string is: " + str);
        Console.WriteLine ("Reversed string is: " + result);
    }
    public static string reverseString(string str)
    {
        string rev = "";
        for(int i=str.Length-1; i>=0; i--)
        {
            rev = rev + str[i];
        }
        return rev;
    }
}
