using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var text = new string('*', n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(text);
        }
    }
}

