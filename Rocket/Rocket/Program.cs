using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var wight = 3 * n;
        var dots = (wight - 2)/2;
        var spaces = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}/{1}\{0}",new string('.',dots),new string(' ',spaces));
            dots--;
            spaces = spaces + 2;
        }
        dots++;
        spaces = spaces -2;
        //head rocket middle
        Console.WriteLine(@"{0}{1}{0}", new string('.', dots), new string('*', spaces+2));
        //lower rocket middle
        for (int i = 0; i < n*2; i++)
        {
            Console.WriteLine("{0}|{1}|{0}",new string('.',dots),new string('\\',spaces));
        }
        //bottom part of the rocket
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine(@"{0}/{1}\{0}",new string('.',dots),new string('*',spaces));
            dots--;
            spaces = spaces + 2;
        }
    }
}
