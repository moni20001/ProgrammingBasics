using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var dots = (((4 * n) + 1) - 3) / 2;
        var dashes = 0;
       
        var height = (2 * n) + 5;
        var dotsCount =(n * 2) - 1;
        var weight = (4 * n) + 1;
        var stars = ((weight / 2) / 2) + 1;
        //top
        Console.WriteLine(@"{0}/|\{0}",new string('.',dots));
        Console.WriteLine(@"{0}\|/{0}", new string('.', dots));
        for (int i = 0; i < height-5; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsCount), new string('-', dashes/2));
           
            dashes = dashes + 2;
            dotsCount = dotsCount - 1;
        }
        //bot
        Console.WriteLine("{0}",new string('*', (4 *n)+ 1));
        for (int i = 0; i < weight/2 ; i++)
        {
            Console.Write("{0}{1}", new string('*', 1), new string('.', 1));
           
        }
        Console.WriteLine("*");
        Console.WriteLine("{0}", new string('*', (4 * n) + 1));
        Thread.Sleep(3000);
    }
 
}
