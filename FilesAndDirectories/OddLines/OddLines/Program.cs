using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var text = File.ReadAllLines("entry.txt");
        File.WriteAllText("output.txt", "");
        for (int i = 0; i < text.Length; i++)
        {
             File.AppendAllText("output.txt", $"{i+1}. "+text[i]+"\r\n");
            
        }
    }
}
