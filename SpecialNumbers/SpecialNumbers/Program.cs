using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var starsFirstRow = 3 * n;
        var dotsFirstRow = n;
        var dotsMiddle = n - 1;
        var starsMiddle = n*3;
        var widthDiamond = 5 * n;

        var height = (3 * n) + 2;
        var bottomPart = height - (n + 1);
        
        Console.WriteLine("{0}{1}{0}",new string('.',dotsFirstRow),new string('*',starsFirstRow));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',dotsMiddle), new string('.', starsMiddle));
            dotsMiddle--;
            starsMiddle = starsMiddle + 2;
        }

        Console.WriteLine("{0}",new string('*',widthDiamond));
        dotsMiddle++;
        starsMiddle = starsMiddle - 2;
        for (int i = 0; i < bottomPart-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsMiddle), new string('.', starsMiddle));
            dotsMiddle++;
            starsMiddle = starsMiddle - 2;
        }

        var lastRow = widthDiamond - (dotsMiddle*2);
        Console.WriteLine("{0}{1}{0}",new string('.',dotsMiddle),new string('*',lastRow));
      

    }
}
