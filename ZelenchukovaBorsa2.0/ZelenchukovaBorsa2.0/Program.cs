using System;

class Program
{
    static void Main(string[] args)
    {
        var cenaZelenchuk = double.Parse(Console.ReadLine());
        var cenaPlod = double.Parse(Console.ReadLine());
        var kilZelenchuk = int.Parse(Console.ReadLine());
        var kilPlod = int.Parse(Console.ReadLine());
        var sum = ((cenaZelenchuk * kilZelenchuk) + (cenaPlod * kilPlod))/1.94;
        Console.WriteLine(sum);
    }
}

