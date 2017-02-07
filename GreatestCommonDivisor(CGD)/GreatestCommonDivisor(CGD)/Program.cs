using System;

class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        if (a == b)
        {
            Console.WriteLine(b);
        }
        else
        {
            while (a != b)
            {
                if (a > b)
                {
                    a /= a - b;

                    break;
                }
                else
                {
                    b /= b - a;
                    break;
                }
            }
           
        }
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
