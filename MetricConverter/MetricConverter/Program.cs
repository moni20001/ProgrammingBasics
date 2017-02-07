using System;

class Program
{
    static void Main(string[] args)
    {
        var num = double.Parse(Console.ReadLine());
        var merna = Console.ReadLine();
        var mernaNum = Console.ReadLine();
        if (merna == "m")
        {
            if (mernaNum == "mm")
            {
                var chislo = num * 1000;
                Console.WriteLine(chislo);
            }
            if (merna == "cm")
            {
                var chislo = num * 100;
                Console.WriteLine(chislo);
            }
            if (merna == "mi")
            {
                var chislo = num * 0.000621371192;
                Console.WriteLine(chislo);
            }
            if (merna == "in")
            {
                var chislo = num * 39.3700787;
                Console.WriteLine(chislo);
            }
            if (merna == "km")
            {
                var chislo = num * 0.001;
                Console.WriteLine(chislo);
            }
            if (merna == "ft")
            {
                var chislo = num * 3.2808399;
                Console.WriteLine(chislo);
            }
            if (merna == "yd")
            {
                var chislo = num * 1.0936133;
                Console.WriteLine(chislo);
            }
        }
        if(merna == "mm")
        {

        }
    }

}