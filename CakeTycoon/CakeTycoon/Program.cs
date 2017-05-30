using System;

class Program
{
    static void Main(string[] args)
    {
        var n = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        var f = double.Parse(Console.ReadLine());
        var t = double.Parse(Console.ReadLine());
        var p = double.Parse(Console.ReadLine());
        var cakes = f / c;
        if (cakes>=n)
        {
            double resultTruffle = t * p;
            double cakePrice = (resultTruffle / n) * 1.25;
            Console.WriteLine("All products available, price of a cake: {0:f2}",cakePrice);
        }
        else
        {
            
            double totalFlour = n * c;
            double kilNeeded = totalFlour - f;
            Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour",Math.Floor(cakes),kilNeeded);  
        }
    }
}

