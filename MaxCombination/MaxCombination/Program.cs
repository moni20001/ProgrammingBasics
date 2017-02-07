using System;
class Program
{
    static void Main(string[] args)
    {
        var startNumb = int.Parse(Console.ReadLine());
        var endNumb = int.Parse(Console.ReadLine());
        var maxComb = int.Parse(Console.ReadLine());
        var counter = 0;
        var firstNumber = startNumb;
        var secondNumber = endNumb;
        for (int i = startNumb; i <= endNumb; i++)
        {
            for (int j = startNumb; j <= endNumb; j++)
            {
                counter++;
                if (counter <= maxComb)
                {
                    Console.Write(@"<{0}-{1}>", i, j);

                }
            }
        }
    }
}
