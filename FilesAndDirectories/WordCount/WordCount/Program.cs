using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');
        string[] text = File.ReadAllText("text.txt").ToLower()
        .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
        StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach(string word in words)
        {
            wordCount[word] = 0;
        }
        foreach(string word in text)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
        }
        var newDic= wordCount.OrderByDescending(x => x.Value);
        foreach (var key in newDic)
        {
            File.AppendAllText("output.txt", $"{key.Key} - {key.Value}\r\n");
        }
    }
}
