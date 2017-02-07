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
                for (int m = 0; m <= 9; m++)
                {
                    for (int s = 0; s <=9; s++)
                    {
                        for (int t = 0; t <= 9; t++)
                        {
                            for (int z = 0; z <= 9; z++)
                            {
                                if(i*j*m*s*t*z == n)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ",i,j,m,s,t,z);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

