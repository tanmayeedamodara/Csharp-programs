/*Program to count no. of words in a given string*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        Program p = new Program();
        int count = p.returnCount(str);
        Console.WriteLine ($"No. of words in {str} is: {count}");
    }
    public int returnCount(string str)
    {
        string s = str.Trim();
        int count=1;
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == ' ' && s[i+1] != ' ')
            {
                count++;
            }
        }
        return count;
    }
    
}
