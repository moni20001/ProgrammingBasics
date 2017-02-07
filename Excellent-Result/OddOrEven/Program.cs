using System;



class Program
{
    static void Main(string[] args)
    {
        var num = double.Parse(Console.ReadLine());
        var num2 = double.Parse(Console.ReadLine());
        if (num>num2)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine(num2);
        }
    }
}
