using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var rows = 2 * n - 1;
        int asterixCount = 1;
        for (int i = 0; i < rows; i++)
        {
            int spaces = n - asterixCount;
            Console.Write(new string(' ', spaces));
            for (int j = 0; j < asterixCount; j++)
            {
                Console.Write("* ");
            }

            if (i < n-1)
            {
                asterixCount++;
            }
            else
            {
                asterixCount--;
            }
            Console.WriteLine();
        }
       
    }
}
