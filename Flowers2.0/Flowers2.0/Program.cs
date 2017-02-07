using System;

class Program
{
    static void Main(string[] args)
    {
        var zakupeniHrizantemi = int.Parse(Console.ReadLine());
        var zakupeniRozi = int.Parse(Console.ReadLine());
        var zakupeniLaleta = int.Parse(Console.ReadLine());
        var season = Console.ReadLine().ToLower();
        var praznik = Console.ReadLine().ToLower();
        if (season == "spring" || season == "summer")
        {
            if (praznik == "y")
            {
                var sum = (zakupeniHrizantemi * (2.00 + (2.00 * 0.15))) + (zakupeniRozi * (4.10 + (4.10 * 0.15))) + (zakupeniLaleta * (2.50 + (2.50 * 0.15)));
                if (zakupeniLaleta > 7)
                {
                    sum = sum - (sum * 0.05);
                }
                if ((zakupeniLaleta + zakupeniHrizantemi + zakupeniRozi) > 20)
                {
                    sum = sum - (sum * 0.20);
                }
                Console.WriteLine("{0:f2}", sum + 2);
            }
            else
            {
                var sum = (zakupeniHrizantemi * 2.00) + (zakupeniRozi * 4.10) + (zakupeniLaleta * 2.50);
                if (zakupeniLaleta > 7)
                {
                    sum = sum - (sum * 0.05);
                }
                if ((zakupeniLaleta + zakupeniHrizantemi + zakupeniRozi) > 20)
                {
                    sum = sum - (sum * 0.20);
                }
                Console.WriteLine("{0:f2}", sum + 2);
            }
        }
        else
        {
            if(praznik == "y")
            {
                var sum = (zakupeniHrizantemi * (3.75 + (3.75 * 0.15)) + zakupeniRozi * (4.50 + (4.50 * 0.15)) + zakupeniLaleta * (4.15 + (4.15 * 0.15)));
                if(season == "winter" && zakupeniRozi >= 10)
                {
                    sum = sum - (sum * 0.10);
                }
                if ((zakupeniLaleta + zakupeniHrizantemi + zakupeniRozi) > 20)
                {
                    sum = sum - (sum * 0.20);
                }
                Console.WriteLine("{0:f2}", sum + 2);
            }
            else
            {
                var sum = (zakupeniHrizantemi * 3.75 ) + (zakupeniRozi * 4.50) + (zakupeniLaleta * 4.15);
                if (season == "winter" && zakupeniRozi>=10)
                {
                    sum = sum - (sum * 0.10);
                }
                if ((zakupeniLaleta + zakupeniHrizantemi + zakupeniRozi) > 20)
                {
                    sum = sum - (sum * 0.20);
                }
                Console.WriteLine("{0:f2}", sum + 2);
            }
        }
    }

}

