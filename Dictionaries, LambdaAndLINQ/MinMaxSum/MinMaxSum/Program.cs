using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        double[] nums = new double[n];
        for (int i = 0; i < n; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            nums[i] = currentNumber;
        }
        Console.WriteLine("Sum = "+nums.Sum());
        Console.WriteLine("Min = "+nums.Min());
        Console.WriteLine("Max = "+nums.Max());
        Console.WriteLine("Average = " + nums.Average());
    }
}
