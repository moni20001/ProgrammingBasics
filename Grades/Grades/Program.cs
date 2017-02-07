using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var dve = 0.0;
        var sreden = 0.0;
        var chetiri = 0.0;
        var pet = 0.0;
        double sredenUspeh = 0.0;
        for (int i = 0; i < n; i++)
        {
            var grade = double.Parse(Console.ReadLine());
            sredenUspeh = sredenUspeh + grade;
            if (grade>=2.00 && grade <= 2.99)
            {
                dve++;
            }
            else if(grade >=3 && grade <= 3.99)
            {
                sreden++;
            }
            else if (grade >= 4 && grade <= 4.99)
            {
                chetiri++;
            }
            else
            {
                pet++;
            }
            
        }
        Console.WriteLine("Top students: {0:f2}%",(pet/n)*100);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",(chetiri/n)*100);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (sreden / n) * 100);
        Console.WriteLine("Fail: {0:f2}%",(dve/n)*100);
        Console.WriteLine("Average: {0:f2}",sredenUspeh/n);
    }
}

