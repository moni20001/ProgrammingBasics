using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var arrayOfWords = Console.ReadLine()
               .ToLower()
               .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
        List<string> shoer = new List<string>();
        foreach (var word in arrayOfWords)
        {
            bool containing = shoer.Contains(word);
            if (word.Length < 5&& !(containing))
            {
                shoer.Add(word);
            }
        }
        Console.WriteLine(string.Join(", ",shoer.OrderBy(x => x)));
    }
}
