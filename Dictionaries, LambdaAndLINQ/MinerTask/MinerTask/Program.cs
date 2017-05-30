using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var Resourse = Console.ReadLine();
        Dictionary<string, int> resourses = new Dictionary<string, int>();
        while (!Resourse.Equals("stop"))
        {
            var amount = int.Parse(Console.ReadLine());
            if (resourses.ContainsKey(Resourse))
            {
                resourses[Resourse] += amount;
            }
            else
            {
                resourses.Add(Resourse, amount);
            }

            //start again 
            Resourse = Console.ReadLine();
        }
        foreach (var res in resourses)
        {
            Console.WriteLine("{0} -> {1}",res.Key,res.Value);
        }
    }
}
