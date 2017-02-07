using System;

class Program
{
    static void Main(string[] args)
    {
        var first = char.Parse(Console.ReadLine());
        var second = char.Parse(Console.ReadLine());
        var third = char.Parse(Console.ReadLine());
        var counter = 0;
        for (char i = first; i <= second; i++)
        {
            for (char j = first; j <= second; j++)
            {
                for(char m = first; m <= second; m++)
                {
                    if(third != i && third!=j && third != m)
                    {
                        Console.Write("{0}{1}{2} ", i, j, m);
                        counter++;
                    }
                    
                }
            }
        }
        Console.Write(counter);

    }
}


