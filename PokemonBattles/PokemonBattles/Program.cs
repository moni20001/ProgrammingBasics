using System;

class Program
{
    static void Main(string[] args)
    {
        var firstPlayerPokemons = int.Parse(Console.ReadLine());
        var secondPlayerPokemons = int.Parse(Console.ReadLine());
        var maxBattles = int.Parse(Console.ReadLine());
        var counter = 0;
        for (int i = 1; i <= firstPlayerPokemons; i++)
        {
            for (int j = 1; j <= secondPlayerPokemons; j++)
            {
                if (counter < maxBattles)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                   
                }
                counter++;
            }
        }
    }
}

