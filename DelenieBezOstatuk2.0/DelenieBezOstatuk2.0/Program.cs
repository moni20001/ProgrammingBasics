using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var twoCount = 0.0;
        var threeCount = 0.0;
        var fourCount = 0.0;
        for (int i = 0; i < n; i++)
        {
            var chislo = int.Parse(Console.ReadLine());
            if (chislo % 2 == 0)
            {
                twoCount++;
            }
            if (chislo % 3 == 0)
            {
                threeCount++;
            }
            if (chislo % 4 == 0)
            {
                fourCount++;
            }
        }
        Console.WriteLine("{0:f2}%",(twoCount/n)*100);
        Console.WriteLine("{0:f2}%", (threeCount / n) * 100);
        Console.WriteLine("{0:f2}%", (fourCount / n) * 100);
    }
}

