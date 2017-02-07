using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var row = "+";
        var middile = "|";
        for (int i = 1; i <= n-2; i++)
        {
            row += " -";
        }
        for (int i = 1; i <= n-2; i++)
        {
            middile += " -";
        }
        row += " +";
        middile += " |";
        Console.WriteLine(row);
        for (int i = 1; i < n-1; i++)
        {
            Console.WriteLine(middile);
        }
        Console.WriteLine(row);

    }
}

