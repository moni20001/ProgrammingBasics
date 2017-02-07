using System;

class Program
{
    static void Main(string[] args)
    {
        var value = double.Parse(Console.ReadLine());
        var valuta = Console.ReadLine();
        var valuta2 = Console.ReadLine();
        if(valuta == "USD")
        {
            if (valuta2 == "BGN")
            {
                var result = value * 1.79549;
                Console.WriteLine(Math.Round(result,2)+" BGN");
            }
            else if(valuta2 == "EUR")
            {
                var result = value * 0.9180;
                Console.WriteLine(Math.Round(result, 2) + " EUR");
            }
            else if (valuta2 == "GBP")
            {
                var result = value * 0.7085456;
                Console.WriteLine(Math.Round(result, 2) + " GBP");
            }
        }
        if(valuta == "BGN")
        {
            if (valuta2 == "USD")
            {
                var result = value * 0.5569510273;
                Console.WriteLine(Math.Round(result, 2) + " USD");
            }
            else if (valuta2 == "EUR")
            {
                var result = value * 0.511292;
                Console.WriteLine(Math.Round(result, 2) + " EUR");
            }
            else if (valuta2 == "GBP")
            {
                var result = value * 0.3946252047;
                Console.WriteLine(Math.Round(result, 2) + " GBP");
            }
        }
        if(valuta == "GBP")
        {
            if(valuta2 == "BGN")
            {
                var result = value * 2.53405;
                Console.WriteLine(Math.Round(result, 2) + " BGN");
            }
            else if (valuta2 == "USD")
            {
                var result = value * 1.41134175;
                Console.WriteLine(Math.Round(result, 2) + " USD");
            }
            else if (valuta2 == "EUR")
            {
                var result = value * 1.295639191;
                Console.WriteLine(Math.Round(result, 2) + " EUR");
            }
        }
        if(valuta == "EUR")
        {
            if (valuta2 == "BGN")
            {
                var result = value * 1.95583;
                Console.WriteLine(Math.Round(result, 2) + " BGN");
            }
            if (valuta2 == "USD")
            {
                var result = value * 1.0893015277;
                Console.WriteLine(Math.Round(result, 2) + " USD");
            }
            if (valuta2 == "GBP")
            {
                var result = value * 0.771819814;
                Console.WriteLine(Math.Round(result, 2) + " USD");
            }

        }
    }
}
