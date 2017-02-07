using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        
        var stars = 1;
    
        //top
        if (n%2 == 0)
        {
            stars = 2;

        }

        for (int i = 0; i < (n + 1)/2 ; i++)
        {
            int dashes = (n - stars) / 2;
            Console.WriteLine("{0}{1}{0}",new string('-',dashes),new string('*',stars));
            stars = stars + 2;
        }

        //bot
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("|{0}|",new string('*',n-2));
        }

    }
}
