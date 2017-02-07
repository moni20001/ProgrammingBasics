using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        char asterix = '*';
        Console.WriteLine("{0}{1}{0}",new string('*',n*2),new string(' ',n));
        for (int i = 1; i < n-1; i++)
        {
            if (n %2 ==0 && i == n/2 -1 )
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", asterix, new string('/', (n * 2) - 2), new string('|', n));
            }
            else if(n%2 != 0 && i == n / 2 )
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", asterix, new string('/', (n * 2) - 2), new string('|', n));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", asterix, new string('/', (n * 2) - 2), new string(' ', n));
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
    }
}

