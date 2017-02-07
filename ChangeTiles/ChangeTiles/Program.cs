using System;
class Program
{
    static void Main(string[] args)
    {
        var money = double.Parse(Console.ReadLine());
        var shirochinaNaPoda = double.Parse(Console.ReadLine());
        var duljinaNaPoda = double.Parse(Console.ReadLine());
        var StranaNaTriagulnika = double.Parse(Console.ReadLine());
        var visochinaNaTriagulnika = double.Parse(Console.ReadLine());
        var cenaNaPlochka = double.Parse(Console.ReadLine());
        var sumataZaMaistora = double.Parse(Console.ReadLine());
        var ploshtNaPoda = shirochinaNaPoda * duljinaNaPoda;
        var ploshtNaPlochka = (StranaNaTriagulnika * visochinaNaTriagulnika) / 2;
        var neobhodimiPlochki = Math.Ceiling(ploshtNaPoda / ploshtNaPlochka) + 5;
        var obshtaSuma = (neobhodimiPlochki * cenaNaPlochka) + sumataZaMaistora;
        var diff = Math.Abs(money - obshtaSuma);
        if (obshtaSuma <= money)
        {
            Console.WriteLine("{0:f2} lv left.",diff);
        }
        else
        {
            Console.WriteLine("You'll need {0:f2} lv more.",diff);
        }
    }
}
