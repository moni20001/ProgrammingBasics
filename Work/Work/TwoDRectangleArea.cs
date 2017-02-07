using System;


class Program
{
    static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        var a = Math.Max(x1, y1);
        var b = Math.Min(x1, y1);
        var one = a - b;

        var c = Math.Max(x2, y2);
        var d = Math.Min(x2, y2);
        var two = c - d;

        var area = one * two;
        var plosht = 2 * (one + two);
        Console.WriteLine(area);
        Console.WriteLine(plosht);
    }
}

