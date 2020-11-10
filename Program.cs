using System;

namespace Fcmb
{
    class Program
    {
        static void Main(string[] args)
        {


            var number = "1234567891234567";
            var card = new  AtmClass();
            var consealedCard = card.CheckAtmCard(number);
            Console.WriteLine(consealedCard);




        }

      
    }
}
