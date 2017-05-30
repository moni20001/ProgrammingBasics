using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var arr = Console.ReadLine().ToLower().Split(' ');
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (var item in arr)
        {
            if (dic.ContainsKey(item))
            {
                dic[item]++;
            }
            else
            {
                dic[item] = 1;
            }
        }
        var results = new List<string>();
        foreach (var item in dic)
        {
            if(!(item.Value%2 == 0))
            {
                results.Add(item.Key);
            }
        }
        Console.WriteLine(string.Join(", ",results));
    }
}
