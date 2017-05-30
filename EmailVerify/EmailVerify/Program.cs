using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        Regex rege = new Regex("([^ -@0-9.][a-z0-9]|[a-z0-9].)+@[a-z]{2,8}.[a-z]{2,8}(.[a-z]{2,6})?");
        var matches = rege.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
