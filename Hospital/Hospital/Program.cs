using System;
class Program
{
    static void Main(string[] args)
    {
        var period = int.Parse(Console.ReadLine());
        var zdravi = 0.0;
        var bolni = 0.0;
        var lekari = 7;
        for (int i = 1; i <= period; i++)
        {
            var pacienti = int.Parse(Console.ReadLine());
            if((i % 3 == 0) && (bolni>zdravi))
            {
                    lekari++;
                
            }
            if (pacienti > lekari)
            {
                zdravi = zdravi + lekari;
                bolni = bolni + pacienti - lekari;
                
            }
            else
            {
                zdravi = zdravi + pacienti;
            }
        }
        Console.WriteLine("Treated patients: {0}.",zdravi);
        Console.WriteLine("Untreated patients: {0}.",bolni);
    }
}

