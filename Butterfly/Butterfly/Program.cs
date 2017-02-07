using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(@"{0}\ /{0}",new string('*',n-2));
        for (int i = 1; i < n-2; i++)
        {
            if(i%2 != 0)
            {
                Console.WriteLine(@"{0}\ /{0}", new string('-', n - 2));
            }
            else
            {
                Console.WriteLine(@"{0}\ /{0}", new string('*', n - 2));
            }
        }
        Console.WriteLine(@"{0} @ {0}", new string(' ', n - 2));
        for (int i = 1; i <= n - 2; i++)
        {
            if (n % 2 == 0)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('-', n - 2));
                }
            }
            else
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('-', n - 2));
                }
            }
        }
        
        //Console.WriteLine(@"{0}/ \{0}", new string('*', n - 2));
    }
}

