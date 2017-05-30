using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var chisloMax = -100000;
        for (int i = 1; i <= n; i++)
        {
            var chislo = int.Parse(Console.ReadLine());
            if (chislo > chisloMax)
            {
                chisloMax = chislo;
            }
        }
        Console.WriteLine(chisloMax);
    }
}

