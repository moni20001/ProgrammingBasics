using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var weight = 5 * n;
        var leftSideFirstRow = 3 * n;
        var rightSideFirstRow = weight - leftSideFirstRow - 2;
        var middleDashes = 0;
        var middle = n / 2;
        var bottom = n / 2;
        
        var middleRowDashesh = n - 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",new string('-',leftSideFirstRow), new string('-', middleDashes), new string('-', rightSideFirstRow));
            middleDashes++;
            if(rightSideFirstRow != 1)
            {
                rightSideFirstRow--;
            }
           
        }
        middleDashes--;
       if(n != 2)
        {
            rightSideFirstRow++;
        }
        
        for (int i = 0; i < middle; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('*', leftSideFirstRow), new string('-', middleRowDashesh), new string('-', rightSideFirstRow));
        }
        for (int i = 0; i < bottom-1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftSideFirstRow), new string('-', middleDashes), new string('-', rightSideFirstRow));
            middleDashes = middleDashes + 2;
            rightSideFirstRow--;
            leftSideFirstRow--;
        }
        var lastRowStars = weight-rightSideFirstRow-leftSideFirstRow;
        
            Console.WriteLine("{0}{1}{2}", new string('-', leftSideFirstRow), new string('*', lastRowStars), new string('-', rightSideFirstRow));
        
    }
}

