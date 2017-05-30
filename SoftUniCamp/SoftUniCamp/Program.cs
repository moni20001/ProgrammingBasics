using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var students = int.Parse(Console.ReadLine());
        var firstGroup = 0.0;
        var secondGroup = 0.0;
        var thirdGroup = 0.0;
        var fourtGroup = 0.0;
        var fifthGroup = 0.0;
        var obshto = 0.0;
        for (int i = 0; i < students; i++)
        {
            var neshto = int.Parse(Console.ReadLine());
            if (neshto <= 5)
            {
                firstGroup = firstGroup + neshto;
            }
            else if(neshto>=6 && neshto <= 12)
            {
                secondGroup = secondGroup + neshto;
            }
            else if(neshto>=13 && neshto <= 25)
            {
                thirdGroup = thirdGroup + neshto;
            }
            else if(neshto>=26 && neshto <= 40)
            {
                fourtGroup = fourtGroup + neshto;
            }
            else if(neshto>=41)
            {
                fifthGroup = fifthGroup + neshto;
            }
            obshto = obshto + neshto;

        }
      
        Console.WriteLine("{0:f2}%",(firstGroup/obshto)*100);
        Console.WriteLine("{0:f2}%", (secondGroup / obshto) * 100);
        Console.WriteLine("{0:f2}%", (thirdGroup / obshto) * 100);
        Console.WriteLine("{0:f2}%", (fourtGroup / obshto) * 100);
        Console.WriteLine("{0:f2}%", (fifthGroup / obshto) * 100);
    }
}

