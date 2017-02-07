using System;

class Program
{
    static void Main(string[] args)
    {
        var n = double.Parse(Console.ReadLine());
        var w = double.Parse(Console.ReadLine());
        var l = double.Parse(Console.ReadLine());
        var m = double.Parse(Console.ReadLine());
        var o = double.Parse(Console.ReadLine());
        var area = n * n;
        var peika = m * o;
        var plosht = area - peika;
        var plochki = w * l;
        var neobhodimi = plosht / plochki;
        var vreme = neobhodimi * 0.2;
        Console.WriteLine(neobhodimi);
        Console.WriteLine(vreme);
    }
}

