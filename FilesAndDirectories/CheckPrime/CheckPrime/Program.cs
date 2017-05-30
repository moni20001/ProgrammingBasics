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
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n%i == 0)
            {
                isPrime = false;
                break;
            }
            
        }
        if(isPrime == true && n >= 2)
        {
            Console.WriteLine("prime");
        }else
        {
            Console.WriteLine("not prime");
        }
    }
}
