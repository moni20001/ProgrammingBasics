using System;

class Program
{
    static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var third = int.Parse(Console.ReadLine());
        var num = (first + second + third)/60;
        var numSeconds = (first + second + third) % 60;
        if (numSeconds < 10)
        {
            Console.WriteLine(+num + ":0" + numSeconds);
        }
        else
        {
            Console.WriteLine(+num + ":" + numSeconds);
        }
    }
}
