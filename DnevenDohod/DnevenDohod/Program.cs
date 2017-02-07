using System;

class Program
{
    static void Main(string[] args)
    {
        var rabotniDni = int.Parse(Console.ReadLine());
        var izkaraniPari = double.Parse(Console.ReadLine());
        var kurs = double.Parse(Console.ReadLine());
        var zaplata = rabotniDni * izkaraniPari;
        var godishenDohod = zaplata * 12 + (zaplata * 2.5);
        var danuk = 0.25 * godishenDohod;
        var chistDohud = godishenDohod - danuk;
        var sum = chistDohud * kurs;
        var naDen = sum / 365;
        Console.WriteLine(Math.Round(naDen,2));
    }
}

