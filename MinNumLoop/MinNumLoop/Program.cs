using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var chislo = 100000;
        for (int i = 1; i <= n; i++)
        {
          var chislo2 = int.Parse(Console.ReadLine());
            if (chislo2 < chislo)
            {
                chislo = chislo2;
            }

        }
        Console.WriteLine(chislo);
    }
}

