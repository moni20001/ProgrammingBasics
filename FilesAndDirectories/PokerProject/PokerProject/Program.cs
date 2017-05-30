using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int credits = 500;
        var cards = new Dictionary<int, string>();
        cards.Add(2, "2");
        cards.Add(3, "2");
        cards.Add(4, "2");
        cards.Add(5, "2");
        cards.Add(6, "2");
        cards.Add(7, "2");
        cards.Add(8, "2");
        cards.Add(9, "2");
        cards.Add(10, "2");
        cards.Add(11, "Joker");
        cards.Add(12, "Qeen");
        cards.Add(13, "King");
        cards.Add(14, "Ace");
        //PLAYER CARDS
        int playerPower = 0;
        Random random = new Random();
        int firstCard = random.Next(2, 14);
        int secondCard = random.Next(2, 14);
        int thirdCard = random.Next(2, 14);
        int forthCard = random.Next(2, 14);
        int fifthCard = random.Next(2, 14);
        //Computer CARDS

        int CompfirstCard = random.Next(2, 14);
        int CompsecondCard = random.Next(2, 14);
        int CompthirdCard = random.Next(2, 14);
        int CompforthCard = random.Next(2, 14);
        int CompfifthCard = random.Next(2, 14);
        int computerPower = 0;
        //CHIFT
        playerPower = NewMethod(playerPower, firstCard, secondCard, thirdCard, forthCard, fifthCard);
        computerPower = NewMethod(computerPower, CompfirstCard, CompsecondCard, CompthirdCard, CompforthCard, CompfifthCard);
        computerPower = NewMethod2(computerPower, CompfirstCard, CompsecondCard, CompthirdCard, CompforthCard, CompfifthCard);
        playerPower = NewMethod2(playerPower, firstCard, secondCard, thirdCard, forthCard, fifthCard);
        //CHIFT

        //Printing Cards and power
        Console.WriteLine("The first card of the Player is : " + firstCard);
        Console.WriteLine("The second card of the Player is : " + secondCard);
        Console.WriteLine("The third card of the Player is : " + thirdCard);
        Console.WriteLine("The forth card of the Player is : " + forthCard);
        Console.WriteLine("The fifth card of the Player is : " + fifthCard);
        Console.WriteLine("The player's score is : " + playerPower);
        Console.WriteLine();
        Console.WriteLine("The first card of the Computer is : " + CompfirstCard);
        Console.WriteLine("The second card of the Computer is : " + CompsecondCard);
        Console.WriteLine("The third card of the Computer is : " + CompthirdCard);
        Console.WriteLine("The forth card of the Computer is : " + CompforthCard);
        Console.WriteLine("The fifth card of the Computer is : " + CompfifthCard);
        Console.WriteLine("The computer's score is : " + computerPower);
        ////Printing Cards and power
    }

    private static int NewMethod2(int playerPower, int firstCard, int secondCard, int thirdCard, int forthCard, int fifthCard)
    {
        if (firstCard.Equals(secondCard)&& firstCard.Equals(thirdCard) || firstCard.Equals(secondCard) && firstCard.Equals(forthCard)||
            firstCard.Equals(secondCard) && firstCard.Equals(fifthCard) || secondCard.Equals(firstCard) && secondCard.Equals(thirdCard)||
             secondCard.Equals(firstCard) && secondCard.Equals(forthCard) || secondCard.Equals(firstCard) && secondCard.Equals(fifthCard)||
              thirdCard.Equals(firstCard) && thirdCard.Equals(secondCard)|| thirdCard.Equals(secondCard) && thirdCard.Equals(forthCard)||
              thirdCard.Equals(firstCard) && thirdCard.Equals(fifthCard)|| thirdCard.Equals(secondCard) && thirdCard.Equals(forthCard)||
              forthCard.Equals(firstCard) && forthCard.Equals(secondCard)|| forthCard.Equals(secondCard) && forthCard.Equals(thirdCard)||
              forthCard.Equals(thirdCard) && forthCard.Equals(fifthCard)|| fifthCard.Equals(firstCard) && fifthCard.Equals(secondCard)||
              fifthCard.Equals(secondCard) && fifthCard.Equals(thirdCard)|| fifthCard.Equals(thirdCard) && fifthCard.Equals(forthCard)||
              firstCard.Equals(thirdCard) && firstCard.Equals(forthCard)
             )
        {
            playerPower += 4;
        }
        return playerPower;
    }

    private static int NewMethod(int playerPower, int firstCard, int secondCard, int thirdCard, int forthCard, int fifthCard)
    {
        if (firstCard == secondCard || firstCard == thirdCard || firstCard == forthCard || firstCard == fifthCard || secondCard == firstCard || secondCard == thirdCard ||
                    secondCard == forthCard || secondCard == fifthCard || thirdCard == fifthCard || thirdCard == secondCard || thirdCard == forthCard || thirdCard == fifthCard ||
                    forthCard == firstCard || forthCard == secondCard || forthCard == thirdCard || forthCard == fifthCard ||
                    fifthCard == firstCard || fifthCard == secondCard || fifthCard == thirdCard || fifthCard == forthCard)
        {
            playerPower += 2;
        }

        return playerPower;
    }
   
    
}