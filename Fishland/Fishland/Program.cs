using System;

class Program
{
    static void Main(string[] args)
    {
        var skumriqCena = double.Parse(Console.ReadLine());
        var cacataCena = double.Parse(Console.ReadLine());
        var kilPalamud = double.Parse(Console.ReadLine());
        var kilSafrid = double.Parse(Console.ReadLine());
        var kilMidi = int.Parse(Console.ReadLine());
        var cenaNaPalamuda = skumriqCena + (skumriqCena * 0.60);
        var sumSalamud = cenaNaPalamuda * kilPalamud;
        var cenaNaSafrid = cacataCena + (cacataCena * 0.80);
        var sumSafrid = kilSafrid * cenaNaSafrid;
        var sumMidi = kilMidi * 7.50;
        Console.WriteLine("{0:f2}", sumMidi + sumSafrid + sumSalamud);
    }
}

