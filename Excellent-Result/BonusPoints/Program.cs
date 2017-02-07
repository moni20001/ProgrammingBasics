using System;

class Program
{
    static void Main(string[] args)
    {
        var num = double.Parse(Console.ReadLine());
        if (num > 0 && num <= 100)
        {
            bool odd = num % 2 == 0;
            bool five = num % 10 == 5;
            if (odd == true)
            {
                var bonusTochki = 1;
                var sum = num + 5 + bonusTochki;
                bonusTochki = 1 + 5;
                Console.WriteLine(bonusTochki);
                Console.WriteLine(sum);

            }
            else if (five == true)
            {
                var bonusTochki = 1;
                var sum = num + 5 + bonusTochki;
                var tochki = bonusTochki + 5;
                Console.WriteLine(tochki);
                Console.WriteLine(sum);
            }
            else
            {
                var sum = num + 5;
                Console.WriteLine(5);
                Console.WriteLine(sum);
            }

        }
        else if (num > 100 && num <= 1000)
        {
            bool odd = num % 2 == 0;
            bool five = num % 10 == 5;
            if (odd == true && five == false)
            {
                var bonus = num * 0.20;
                var bonusTochki = 1;
                var bonusi = bonus + bonusTochki;
                var sum = bonus + bonusTochki;
                Console.WriteLine(bonusi);
                Console.WriteLine(sum);
            }

            else if (five == true && odd == false)
            {
                var bonus = num * 0.20;
                var bonusTochki = 2;
                var bonusi = bonus + bonusTochki;
                var sum = bonus + bonusTochki;
                Console.WriteLine(bonusi);
                Console.WriteLine(sum);
            }
            else if (five == false && odd == false)
            {
                var bonus = num * 0.20;
                var bonusTochki = 0;
                var bonusi = bonus + bonusTochki;
                var sum = bonus + bonusTochki;
                Console.WriteLine(bonusi);
                Console.WriteLine(sum);
            }

            else if (five == true)
            {
                var bonusTochki = 1;
                var bonus = num * 0.20;
                var bonusi = bonusTochki + bonus;
                Console.WriteLine(bonusi);
                var sum = bonusi + num;
                Console.WriteLine(sum);
            }


        }



        else if (num > 1000)
        {
            bool odd = num % 2 == 0;
            bool five = num % 10 == 5;
            if (odd == true)
            {
                if (five == true)
                {
                    var bonusPoints = 2 + 1;
                    double points = (num / 10) + bonusPoints;
                    double sum2 = num + points;
                    Console.WriteLine(points);
                    Console.WriteLine(sum2);
                }
                else
                {
                    var bonusPoints = 1;
                    double points = (num / 10) + bonusPoints;
                    double sum2 = num + points;
                    Console.WriteLine(points);
                    Console.WriteLine(sum2);
                }

            }
            else if (odd == false)
            {
                if (five == true)
                {
                    var bonusPoints = 2;
                    double points = (num / 10) + bonusPoints;
                    double sum2 = num + points;
                    Console.WriteLine(points);
                    Console.WriteLine(sum2);
                }
                if (five == false)
                {
                    var bonusPoints = 0;
                    double points = (num / 10) + bonusPoints;
                    double sum2 = num + points;
                    Console.WriteLine(points);
                    Console.WriteLine(sum2);
                }
            }

        }

    }
}

