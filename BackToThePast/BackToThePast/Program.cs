using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var money = double.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var startingYear = 1800;
        var godini = 18;
        for (int i = startingYear; i <= year; i++)
        {
            if (i % 2==0)
            {
                money -= 12000;
                godini++;
            }
            else
            {
                money -= 12000 + 50 * godini;
                godini++;
            }
        }
        if (money >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",money);
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(money));
        }
    }
}

