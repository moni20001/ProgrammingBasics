using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var height = n * 2 - 1;
        var weight = n * 2 - 1;
        var spaces = new string(' ', 1);
        var star = new string('*', 1);
        var firstrow = " ";
        if (n == 1)
        {
            Console.WriteLine("*");
        }else
        {
            for (int i = 1; i <= n*2-1; i++)
            {
                Console.Write(" * ");
            }
        }
    }
}

