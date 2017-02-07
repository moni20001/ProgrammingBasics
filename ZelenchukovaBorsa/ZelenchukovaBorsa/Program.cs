using System;

class Program
{
    static void Main(string[] args)
    {
        var cenaNaZelenchuk = double.Parse(Console.ReadLine());
        var cenaNaPlodovete= double.Parse(Console.ReadLine());
        var kilZelenchuk = int.Parse(Console.ReadLine());
        var kilPlod = int.Parse(Console.ReadLine());
        var obshto1 = cenaNaPlodovete * kilPlod;      
        var obshto2 = cenaNaZelenchuk * kilZelenchuk;
        var obshto = obshto1 + obshto2;
        var valuta = 1 / 1.94;
        var vevro = obshto * valuta;
        Console.WriteLine(vevro);
    }
}
