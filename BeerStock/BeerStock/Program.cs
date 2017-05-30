using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        char symbol = ' ';
        Console.WriteLine(@"{0}\ /{0}", new string('*', n - 2));
        for (int i = 1; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                symbol = '*';
            }
            else
            {
                symbol = '-';
            }

            Console.WriteLine(@"{0}\ /{0}", new string(symbol, n - 2));
        }
        Console.WriteLine(@"{0} @ {0}", new string(' ', n - 2));
        for (int i = 1; i <= n - 2; i++)
        {
            if (i % 2 == 0)
            {
                symbol = '-';
            }
            else
            {
                symbol = '*';
            }

            Console.WriteLine(@"{0}\ /{0}", new string(symbol, n - 2));
        }
    }
}  