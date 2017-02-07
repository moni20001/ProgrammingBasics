using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var num = 1;
        for (int i = 1; i <= n; i = i++)
        {
            for (int j = 1; j < i; j = j *4)
            {
                Console.WriteLine(j);
            }

        }

    }
}
