using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0.0;
        var p1 = 0.0;
        var p2 = 0.0;
        var p3 = 0.0;
        for (int i = 0; i < n; i++)
        {
            var curr = double.Parse(Console.ReadLine());
            if (curr % 2 == 0) p1++;
            if (curr % 3 == 0) p2++;
            if (curr % 4 == 0) p3++;
            sum++;
        }
        Console.WriteLine("{0:F02}%",(p1/sum)*100);
        Console.WriteLine("{0:F02}%", (p2 / sum) * 100);
        Console.WriteLine("{0:F02}%", (p3 / sum) * 100);
    }
}
