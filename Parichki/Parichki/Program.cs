using System;

class Program
{
    static void Main(string[] args)
    {
        var bitcoin = int.Parse(Console.ReadLine());
        var yuni = double.Parse(Console.ReadLine());
        var komis = double.Parse(Console.ReadLine());
        var sum1 = bitcoin * 1168;
        var sum2 = yuni * 0.15;
        var sum3 = sum2 * 1.76;
        var obshto = sum3 + sum1;
        var valuta = 1 / 1.95;
        var vevro = obshto * valuta;
        var procent = 100 - komis;
        var komiss = (vevro / 100) * procent;
        Console.WriteLine(komiss);
    }
}