using System;

class Program
{
    static void Main(string[] args)
    {
        var speed = double.Parse(Console.ReadLine());
        var first = double.Parse(Console.ReadLine())/60;
        var second =double.Parse(Console.ReadLine())/60;
        var third = double.Parse(Console.ReadLine())/60;
        var sum = speed * first;
        
        var sum1 = (speed + speed * 0.10) * second;
        speed = speed * 0.10 + speed;

        var sum2 = (speed - (speed * 0.05)) * third;
        Console.WriteLine("{0:f2}",sum+ sum1 + sum2);
        
    }
}

