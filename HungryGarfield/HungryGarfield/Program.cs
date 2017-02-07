using System;

class Program
{
    static void Main(string[] args)
    {
        var money = decimal.Parse(Console.ReadLine());
        var exchange = decimal.Parse(Console.ReadLine());
        var pizzaPrice = decimal.Parse(Console.ReadLine())/exchange;
        var lasagnaPrice = decimal.Parse(Console.ReadLine())/exchange;
        var sandwichPrice = decimal.Parse(Console.ReadLine())/exchange;
        var pizzaQuantity = uint.Parse(Console.ReadLine());
        var lasagnaQuantity = uint.Parse(Console.ReadLine());
        var sandwichQuantity = uint.Parse(Console.ReadLine());
        decimal spentForPizza = pizzaPrice * pizzaQuantity;
        decimal spentForLasagna = lasagnaPrice * lasagnaQuantity;
        decimal spentForSandwiches = sandwichPrice * sandwichQuantity;
        decimal totalNeeded = spentForLasagna + spentForPizza + spentForSandwiches;
        var diff = money - totalNeeded;
        var diff2 = totalNeeded - money;
        if (money - totalNeeded >=0)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.",diff);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.",Math.Abs(diff2));
        }
    }
}

