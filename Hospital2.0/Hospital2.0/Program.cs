using System;

class Program
{
    static void Main(string[] args)
    {
        var period = int.Parse(Console.ReadLine());
        var lekari = 7;
        var zdravi = 0;
        var bolni = 0;
        var obshtoPacienti = 0;
        for (int i = 0; i < period; i++)
        {
            var pacienti = int.Parse(Console.ReadLine());
            if(i%3 == 0 && (obshtoPacienti-zdravi)>zdravi)
            {
                lekari++;
                if (lekari >= pacienti)
                {
                    zdravi = zdravi + pacienti;
                }
                else
                {
                    zdravi = zdravi + lekari;
                }
            }
            else
            {
                if (lekari >= pacienti)
                {
                    zdravi = zdravi + pacienti;
                }
                else
                {
                    zdravi = zdravi + lekari;
                }
              
            }
            obshtoPacienti = obshtoPacienti + pacienti;
        }
        bolni = obshtoPacienti - zdravi;
        Console.WriteLine("Treated patients: {0}",zdravi);
        Console.WriteLine("Untreated patients: {0}",Math.Abs(bolni));
    }
}
