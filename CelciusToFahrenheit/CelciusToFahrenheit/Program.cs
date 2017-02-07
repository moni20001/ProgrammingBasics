using System;

class Program
{
    static void Main(string[] args)
    {
        var celcius = double.Parse(Console.ReadLine());
        var fahrenheit = celcius * 9 / 5 + 32;
        Console.WriteLine(fahrenheit);
    }
}
