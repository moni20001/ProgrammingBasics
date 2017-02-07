using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum = sum * i;
        }
        Console.WriteLine(sum);
    }
}
