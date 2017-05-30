using System;

class Program
{
    static void Main(string[] args)
    {
        var broiYoung = int.Parse(Console.ReadLine());
        var broiOld = int.Parse(Console.ReadLine());
        var trace = Console.ReadLine();
        var taxJunior = 0.0;
        var taxSeniors = 0.0;
        var obshtBroi = broiOld + broiYoung;
        if(trace == "trail")
        {
            taxJunior = 5.5;
            taxSeniors = 7.0;
        }
        else if(trace == "cross-country")
        {
            taxJunior = 8.0;
            taxSeniors = 9.50;
            if (obshtBroi >= 50)
            {
                taxJunior = taxJunior - (taxJunior * 0.25);
                taxSeniors = taxSeniors - (taxSeniors * 0.25);
            }
        }
        else if(trace == "downhill")
        {
            taxJunior = 12.25;
            taxSeniors = 13.75;
        }
        else
        {
            taxJunior = 20.00;
            taxSeniors = 21.50;
        }
        var sum = (broiYoung * taxJunior) + (taxSeniors * broiOld);
        var razhodi = sum * 0.05;
        Console.WriteLine("{0:f2}",sum-razhodi);
    }
}

