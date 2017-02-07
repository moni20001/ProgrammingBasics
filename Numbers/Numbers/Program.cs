using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var firstNumber = n / 100;
        var secondNumber = (n / 10) % 10;
        var thirdNumber = n % 10;

        var colums = firstNumber + secondNumber;
        var rows = firstNumber + thirdNumber;
        var number = n;
        for (int i = 0; i < colums; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if(number%5 == 0)
                {
                    number -= firstNumber;
                }
                else if (number % 3 == 0)
                {
                    number -= secondNumber;
                }
                else
                {
                    number += thirdNumber;
                }
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}

