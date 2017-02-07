using System;

class Program
{
    static void Main(string[] args)
    {
        var num = double.Parse(Console.ReadLine());

        if (num <= 100)
        {
            var five = num % 10 == 5;
            var even = num % 2 == 0;
            if(five == true)
            {
                var bonusPoints = 2 + 5;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints+num);
            }
            else if(even == true)
            {
                var bonusPoints = 1 + 5;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints+num);
            }
            else
            {
                var bonusPoints = 5;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + num);
            }
        }
        else if(num>100 && num <= 1000)
        {
            var five = num % 10 == 5;
            var even = num % 2 == 0;
            if(five == true)
            {
                var bonusPoints = (num * 0.20) + 2;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints+num);
            }
            else if(even == true)
            {
                var bonusPoints = (num * 0.20) + 1;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + num);
            }
            else
            {
                var bonusPoints = num * 0.20;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + num);

            }
        }
        else
        {
            var five = num % 10 == 5;
            var even = num % 2 == 0;
            if (five == true)
            {
                var bonusPoints = (num * 0.10) + 2;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + num);
            }
            else if (even == true)
            {
                var bonusPoints = (num * 0.10) + 1;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + num);
            }
            else
            {
                var bonusPoints = num * 0.10;
                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + num);

            }
        }
    }
}

