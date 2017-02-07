using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var secondRowSpaces = n;
        var spaces = n + 1;
        var asterix = 1;
        var spaceCount = n - 1;
        Console.WriteLine("{0}|{0}", new string(' ', spaces));
        for (int i = 0; i < n; i++)
        {
            var space = (n + 1)-asterix;
            Console.WriteLine("{0}{1} | {1}{0}",new string(' ',spaceCount),new string('*',asterix));
            asterix++;
            spaceCount--;
        }
    }
}

