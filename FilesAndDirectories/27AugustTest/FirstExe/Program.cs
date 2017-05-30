using System;

class Program
{
    static void Main(string[] args)
    {
        var first = double.Parse(Console.ReadLine());
        var second = double.Parse(Console.ReadLine());
        var third = double.Parse(Console.ReadLine());
        var fourth = double.Parse(Console.ReadLine());
        var sum = ((first * third) + (second * fourth)) / 1.94;
        Console.WriteLine("{0}",sum);
    }
}
