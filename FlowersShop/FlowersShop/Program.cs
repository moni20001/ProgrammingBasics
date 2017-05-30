using System;

class Program
{
    static void Main(string[] args)
    {
        var magnolii = int.Parse(Console.ReadLine());
        var zombuli = int.Parse(Console.ReadLine());
        var rozi = int.Parse(Console.ReadLine());
        var kaktusi = int.Parse(Console.ReadLine());
        var cena = double.Parse(Console.ReadLine());
        var sum = (magnolii * 3.25) + (zombuli * 4) + (rozi * 3.50) + (kaktusi * 8);
        var danuk = sum * 0.05;
        var pechalba = sum - danuk;
        var neshto = (cena - pechalba);
        if (neshto > 0)
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Abs(Math.Ceiling(neshto)));
           
        }
        else
        {
            
            Console.WriteLine("She is left with {0} leva.", Math.Abs(Math.Ceiling(neshto)));
        }
    }
}

