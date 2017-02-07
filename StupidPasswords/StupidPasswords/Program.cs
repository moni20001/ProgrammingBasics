using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <=n; j++)
            {
                for (int m = 0; m < l; m++)
                {
                    for (int s = 0; s < l; s++)
                    {
                        for (int p = 1; p <= n; p++)
                        {
                            if(p>i && p > j)
                            {
                                char first = (char)(m + 97);
                                char second = (char)(s + 97);
                                string result = i.ToString() + j + first + second + p;
                                Console.Write(result + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
