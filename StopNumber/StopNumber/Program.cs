using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var s = int.Parse(Console.ReadLine());

        for (int i = m; m >= n; m--)
        {
            if (m % 2 == 0 && m % 3 == 0)
            {
                if (s == m)
                {
                    break;
                }

                Console.Write("{0} ", m);

            }
        }
    }
}
