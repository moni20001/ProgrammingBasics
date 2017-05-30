using System;

class Program
{
    static void Main(string[] args)
    {
        var ploshtaMalka = double.Parse(Console.ReadLine());
        var ploshtaKuchnq = double.Parse(Console.ReadLine());
        var cena = double.Parse(Console.ReadLine());
        var vtora = ploshtaMalka + (ploshtaMalka * 0.10);
        var treta = vtora + (vtora*0.10);
        var banq = ploshtaMalka / 2;
        var obshto = ploshtaMalka + ploshtaKuchnq + vtora + treta + banq;
        var koridor = obshto * 0.05;
        var sum = obshto + koridor;
        Console.WriteLine("{0:f2}",sum *cena);
    }
}

