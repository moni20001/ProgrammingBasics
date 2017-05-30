using System;

class Program
{
    static void Main(string[] args)
    {
        var days = int.Parse(Console.ReadLine());
        var foodLeft = int.Parse(Console.ReadLine());
        var dogKilos = double.Parse(Console.ReadLine());
        var catKilos = double.Parse(Console.ReadLine());
        var kostenurkaKilos = double.Parse(Console.ReadLine());
        var dogsNujna = days * dogKilos;  
        var catNujna = days * catKilos;
        var kostenurkaNujna = (days * kostenurkaKilos)/1000;
        var obshtoHrana = dogsNujna + catNujna + kostenurkaNujna;
        var fooodLeft = Math.Abs(obshtoHrana - foodLeft);
        if(obshtoHrana<= foodLeft)
        {
            Console.WriteLine("{0} kilos of food left.",Math.Floor(fooodLeft));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(fooodLeft));
        }
    }
}

