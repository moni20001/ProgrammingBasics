using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var spaces = n - 2;
        string space = " -";

        for (int i = 1; i < n-2; i++)
        {
            space += " -";
        }
        Console.WriteLine("{0}{1} {0}", new string('+', 1), space);
        for (int i = 1; i < n-1; i++)
        {
            Console.WriteLine("{0}{1} {0}", new string('|', 1), space);
        }
      
        Console.WriteLine("{0}{1} {0}", new string('+', 1), space);
    }
}
