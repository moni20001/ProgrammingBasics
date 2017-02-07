using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var wight = (2 * n) + 3;
        var startingStars = 1;
        var startingDashesh = wight - (startingStars * 2) - 2;
        var middleRows = n / 3;
        var middleMiddleStars = n;
        var middleLeftSideStars = (wight - middleMiddleStars - 4)/2;
        //top
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}", new string('*',startingStars),new string('-',startingDashesh));
            startingDashesh = startingDashesh - 2;
            startingStars++;
        }
        for (int i = 0; i < middleRows; i++)
        {
            Console.WriteLine(@"|{0}\{1}/{0}|",new string ('*',middleLeftSideStars),new string('*',middleMiddleStars));
            middleMiddleStars = middleMiddleStars - 2;
            middleLeftSideStars++;
        }
        //bot
        var botDashes = 1;
        var botStars = wight - (botDashes * 2) - 2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}",new string('-',botDashes),new string('*',botStars));
            botDashes++;
            botStars = botStars - 2;
        }
    }
}
