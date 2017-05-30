using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int s = 0; s <=9; s++)
                {
                    for (int m = 0; m <=9; m++)
                    {
                        for (int v = 0; v <=9; v++)
                        {
                            for (int t = 0; t <=9; t++)
                            {
                                if ((i * j * s * m * v * t) == n)  Console.Write("{0}{1}{2}{3}{4}{5} ",i,j,s,m,v,t);
                            }
                        }
                    }
                }
            }
        }
    }
}
