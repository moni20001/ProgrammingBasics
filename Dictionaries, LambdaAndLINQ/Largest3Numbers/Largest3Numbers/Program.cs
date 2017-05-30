﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
       
        var numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();
        var orederList = numbers.OrderByDescending(x => x).Take(3);
        Console.WriteLine(string.Join(" ",orederList));

    }
}

