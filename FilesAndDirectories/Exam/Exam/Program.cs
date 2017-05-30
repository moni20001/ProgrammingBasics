using System;
class Program
{
    static void Main()
    {
        //  var n = int.Parse(Console.ReadLine());
        //  var shirina = 2 * n + 1;
        //  Console.WriteLine("{0}", new string('*', shirina));
        //  Console.WriteLine(".*{0}*.", new string(' ', shirina - 4));
        //  var startDots = 2;
        //  var monkeys = shirina - (2 * startDots) - 2;
        //  for (int i = 0; i < n - 2; i++)
        //  {
        //      Console.WriteLine("{0}*{1}*{0}", new string('.', startDots), new string('@', monkeys));
        //      monkeys -= 2;
        //      startDots++;
        //  }
        //  //middle 
        //  Console.WriteLine("{0}*{0}", new string('.', (shirina - 1) / 2));
        //
        //  //start BottomPart
        //  startDots--;
        //  var spaces = shirina - 3 - (startDots * 2);
        //  for (int i = 0; i < n - 2; i++)
        //  {
        //      Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', startDots), new string(' ', spaces));
        //      startDots--;
        //      spaces++;
        //  }
        //  //predPosledenRed
        //  Console.WriteLine(".*{0}*.",new string('@',shirina-4));
        //  Console.WriteLine("{0}",new string('*',shirina));
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());
        var magicNum = int.Parse(Console.ReadLine());
        var combinations = 0;
        var much = 0;
        bool moni = false;
        for (int i = start; i >= end; i--)
        {
            for (int j = start; j >= end; j--)
            {
                
                combinations++;
                if(j+i == magicNum)
                {
                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinations, i, j, magicNum);
                
                    much++;
                    moni = true;
                }
                if(moni == true)
                {
                    break;
                }
            }
            if (moni == true)
            {
                break;
            }
        }
        if (much == 0)
        {
            Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNum);
        }
        
    }
}