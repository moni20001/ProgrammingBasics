using System;
class Program
{
    static void Main(string[] args)
    {
        var V = int.Parse(Console.ReadLine());
        var P1 = int.Parse(Console.ReadLine());
        var P2 = int.Parse(Console.ReadLine());
        var H = double.Parse(Console.ReadLine());
        var sumPipeOne = P1 * H;
        var sumPipeTwo = P2 * H;
        var sum = sumPipeOne + sumPipeTwo;
        var percentageOne = Math.Truncate((sumPipeOne / sum) * 100);
        var percentageTwo = Math.Truncate((sumPipeTwo / sum) * 100);
        var percentageSum = (sum / V) * 100;
        var oveflow = V - sum;
        if (sum<= V)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Truncate(percentageSum),percentageOne,percentageTwo);
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H,Math.Abs(oveflow));
        }
    }
}

