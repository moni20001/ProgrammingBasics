using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ');
        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
       
        foreach (var number in numbers)
        {
            double parsedNum = double.Parse(number);
            if (counts.ContainsKey(parsedNum))
            {
                counts[parsedNum]++;
            }
            else
            {
                counts[parsedNum] = 1;
            }
        }
        foreach (var number in counts.Keys)
        {
            Console.WriteLine("{0} -> {1}",number,counts[number]);
        }
    }
}
