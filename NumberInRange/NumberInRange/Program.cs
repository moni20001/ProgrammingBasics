using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number in the range [1...100]: ");
        var n = int.Parse(Console.ReadLine());
        while (!(n >0 && n<=100))
        {
            Console.WriteLine("Invalid number");
           n = int.Parse(Console.ReadLine());
            
        }
        if (n > 0 && n <= 100)
        {
            Console.WriteLine("The number is: " + n);
        }
    }
}
