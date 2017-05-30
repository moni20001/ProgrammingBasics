using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int number = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <=i; j++)
            {
                if (number >= n)
                {
                    break;
                }
                number++;
                Console.Write("{0} ", number);
               
            }
            if (number >= n)
            {
                break;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
