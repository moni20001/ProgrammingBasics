using System;
class Program
{
    static void Main(string[] args)
    {
        var w = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        var a = w * 100;
        var b = h * 100;
        var sredno = Math.Truncate(a / 120);
        var abc = b - 100;
        var sredno2 = Math.Truncate(abc / 70);
        var obshto = (sredno * sredno2) - 3;
        Console.WriteLine(obshto);
    }
}
