﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine(1);
        }
        int f0 = 1;
        int f1 = 1;
        for (int i = 0; i < n-1; i++)
        {
            var sum = f0 + f1;
            f0 = f1;
            f1 = sum;
        }
        Console.WriteLine(f1);
    }
}
