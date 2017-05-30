using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var weight = 2 * n - 1;
        var height = 2 * (n - 2) + 1;

        for (int i = 0; i < n-2; i++)
        {
            if(i%2 == 0)
            {
                DrawStars(n);
            }
            else
            {
                DrawDash(n);
            }
        }
        Console.WriteLine("{0}@{0}",new string(' ',n-1));
        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                DrawStarsTwo(n);
            }
            else
            {
                DrawDashTwo(n);
            }
        }

    }

    private static void DrawStars(int n)
    {
        Console.WriteLine(@"{0}\ /{0}",new string('*',n-2));
    }
    private static void DrawDash(int n)
    {
        Console.WriteLine(@"{0}\ /{0}", new string('-', n - 2));
    }
    private static void DrawStarsTwo(int n)
    {
        Console.WriteLine(@"{0}/ \{0}", new string('*', n - 2));
    }
    private static void DrawDashTwo(int n)
    {
        Console.WriteLine(@"{0}/ \{0}", new string('-', n - 2));
    }
}
