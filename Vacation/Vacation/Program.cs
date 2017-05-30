using System;

class Program
{
    static void Main(string[] args)
    {
        var oldPeople = int.Parse(Console.ReadLine());
        var uchenici = int.Parse(Console.ReadLine());
        var nights = int.Parse(Console.ReadLine());
        var transport = Console.ReadLine().ToLower();
        var sum = 0.0;
        var hotel = 0.0;
        var komisionna = 0.0;
        
        if(transport == "airplane")
        {
            sum = ((oldPeople * 70.00) + (uchenici * 50.00))*2;
            hotel = nights * 82.99;
            komisionna = (sum + hotel) * 0.10;
        }
        else if (transport == "train")
        {
            if((oldPeople + uchenici) >= 50)
            {
                var bonusOldPeople = 24.99 - (24.99 * 0.50);
                var bonusDeca = 14.99-(14.99 * 0.50);
                sum = ((oldPeople * bonusOldPeople) + (bonusDeca * uchenici)) * 2;
                hotel = nights * 82.99;
                komisionna = (sum + hotel) * 0.10;
            }
            else
            {
                sum = ((oldPeople * 24.99) + (uchenici * 14.99))*2;
                hotel = nights * 82.99;
                komisionna = (sum + hotel) * 0.10;
            }
            
        }
        else if (transport == "bus")
        {
            sum = ((oldPeople * 32.50) + (uchenici * 28.50))*2;
            hotel = nights * 82.99;
            komisionna = (sum + hotel) * 0.10;
        }
        else
        {
            sum = ((oldPeople * 42.99) + (uchenici * 39.99))*2;
            hotel = nights * 82.99;
            komisionna = (sum + hotel) * 0.10;
        }
        Console.WriteLine("{0:f2}", sum+ hotel + komisionna);
    }
}

