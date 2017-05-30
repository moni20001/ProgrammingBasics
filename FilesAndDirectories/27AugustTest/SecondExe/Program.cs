using System;

class Program
{
    static void Main(string[] args)
    {
        var v = double.Parse(Console.ReadLine());
        var p1 = double.Parse(Console.ReadLine());
        var p2 = double.Parse(Console.ReadLine());
        var time = double.Parse(Console.ReadLine());
        double pipeOne = time * p1;
        double pipeTwo = time * p2;
        double sumPipe = pipeTwo + pipeOne;
        if (sumPipe <= v)
        {
            Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Truncate((sumPipe/v)*100),Math.Truncate((pipeOne/sumPipe)*100),Math.Truncate((pipeTwo/sumPipe)*100));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",time,Math.Abs(v-sumPipe));
        }
    }
}
