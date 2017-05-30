using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;
        for (int i = 0; i < n; i++)
        {
            var chislo = int.Parse(Console.ReadLine());
            sum = sum + chislo;
        }
        Console.WriteLine(sum);
    }
}

