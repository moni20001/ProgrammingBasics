using System;
class Program
{
    static void Main(string[] args)
    {
        var broi = int.Parse(Console.ReadLine());
        var firstGroup = 0.0;
        var secondGroup = 0.0;
        var thirdGroup = 0.0;
        var obshtBroi = 0.0;
        for (int i = 0; i < broi; i++)
        {
            var neshto = int.Parse(Console.ReadLine());
            if (neshto <= 3)
            {
                firstGroup = firstGroup + neshto;
            }
            else if(neshto>=4 && neshto <= 11)
            {
                secondGroup = secondGroup + neshto;
            }
            else
            {
                thirdGroup = thirdGroup + neshto;
            }
            obshtBroi = obshtBroi + neshto;
        }
        var srednoTon = (firstGroup * 200) + (secondGroup * 175) + (thirdGroup * 120);
        Console.WriteLine("{0:f2}",srednoTon/obshtBroi);
        Console.WriteLine("{0:f2}%",(firstGroup/obshtBroi)*100);
        Console.WriteLine("{0:f2}%", (secondGroup / obshtBroi) * 100);
        Console.WriteLine("{0:f2}%", (thirdGroup / obshtBroi) * 100);
    }
}

