using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        //top
        var dotsFirstRow = new string('.', n + 1);
        var dashesFirstRow = new string('_', (2 * n) + 1);
        var dotsMiddle = n;
        var dasheshMiddle = (2 * n) - 1;
        var stop = "STOP!";
        Console.WriteLine("{0}{1}{0}",dotsFirstRow,dashesFirstRow);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}//{1}\\{0}",new string('.',dotsMiddle),new string('_',dasheshMiddle));
            dotsMiddle--;
            dasheshMiddle = dasheshMiddle +2;
        }
        Console.WriteLine(@"//{0}{1}{0}\\",new string('_',(dasheshMiddle-5)/2),stop);

        //bot
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}\\{1}//{0}", new string('.', dotsMiddle), new string('_', dasheshMiddle));
            dotsMiddle++;
            dasheshMiddle = dasheshMiddle - 2;
        }
    }
}
