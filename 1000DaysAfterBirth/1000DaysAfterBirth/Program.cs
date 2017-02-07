using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       CultureInfo provider = CultureInfo.InvariantCulture;
        String format = "dd-MM-yyyy";
        var date = Console.ReadLine();
        var date2 = DateTime.ParseExact(date, "dd-MM-yyyy", provider);
        DateTime dt = Convert.ToDateTime(date2);
        var answer = dt.AddDays(999);
        DateTime danswer = Convert.ToDateTime(answer);
        Console.WriteLine(danswer.Date.ToString("dd-MM-yyyy"));
    }
}
