using System;

public class Program
{
    public static void Main(string[] args)
    {
        string inp1 = Console.ReadLine();
        int a = int.Parse(inp1);
        string inp2 = Console.ReadLine();
        int.TryParse(inp2, out int b);
        
        Console.WriteLine($"sum of {a} and {b} is {a+b}");
    }
}
