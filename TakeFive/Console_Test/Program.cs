using System;
using System.Collections.Generic;
using TakeFive_AI;

namespace Console_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = new List<Card>();
            List<Column> columns = new List<Column>();

            Player player1 = new Player();
            Player player2 = new Player();
            Player player4 = new Player();
            Player player3 = new Player();

            player1.hand = Engine.DealCards(10);
            //player2.hand = Engine.DealCards(10);
            //player3.hand = Engine.DealCards(10);
            //player4.hand = Engine.DealCards(10);


            Engine.CreateCards(104);

            Engine.GetInitialCards();

            Console.WriteLine();

            deck = Engine.GetCards();

            foreach (Card item in deck)
            {
                Console.WriteLine(item.number.ToString());
            }
            
            /*
            columns = Engine.ShowColumns();

            foreach (Column item in columns)
            {
                foreach (Card card in item.cardsInColumn)
                {
                    Console.Write(card.number.ToString());
                }

                Console.WriteLine();
            }
            */

            Console.ReadKey();
        }
    }
}
