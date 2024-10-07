using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeFive_AI
{
    public static class Engine
    {
        const int MINIMUM_NUMBER_OF_PLAYERS = 2;
        const int MAXIMUM_NUMBER_OF_PLAYERS = 10;
        const int POINTS_TO_END_GAME = 66;
        const int NUMBER_OF_COLUMNS = 4;
        const int TOTAL_NUMBER_OF_CARDS = 104;
        static List<Card> cards = new List<Card>();
        static List<Card> playedCards = new List<Card>();
        static Column column1;
        static Column column2;
        static Column column3;
        static Column column4;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardsNum"></param>
        public static void CreateCards(int cardsNum)
        {
            if (cardsNum > 0)
            {
                for (int i = 0; i < cardsNum;)
                {
                    i++;
                    cards.Add(new Card(i, 1));
                }

                ShuffleCards();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void ShuffleCards()
        {
            Random rand = new Random();

            cards = cards.OrderBy(_ => rand.Next()).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardsInHand"></param>
        /// <param name="numberOfPlayers"></param>
        /// <returns></returns>
        public static List<Card> DealCards(int cardsInHand)
        {
            List<Card> cardsDealed = new List<Card>();
            
            if (cardsInHand > 0)
            {
                cardsDealed = cards.GetRange(0, cardsInHand).ToList();
                cards.RemoveRange(0, cardsInHand);
            }

            return cardsDealed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static void GetInitialCards()
        {
            column1 = new Column(cards.First());
            cards.Remove(cards.First());
            column2 = new Column(cards.First());
            cards.Remove(cards.First());
            column3 = new Column(cards.First());
            cards.Remove(cards.First());
            column4 = new Column(cards.First());
            cards.Remove(cards.First());
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SortCardsPlayed()
        {
            int aux = 0;

            foreach (Card item in playedCards)
            {
                aux = item.number;
            }

            ClearPlayedCards();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardsToCount"></param>
        /// <returns></returns>
        public static int CountPoints(List<Card> cardsToCount)
        {
            int totalPoints = 0;

            foreach (Card item in cardsToCount)
            {
                totalPoints += item.bullsNumber;
            }

            return totalPoints;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="negativePoints"></param>
        /// <returns></returns>
        public static bool CheckForGameEnd(int negativePoints)
        {
            bool gameEnd = false;

            if (POINTS_TO_END_GAME <= negativePoints)
            {
                gameEnd = true;
            }

            return gameEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playedCard"></param>
        public static void ReceiveCard(Card playedCard)
        {
            playedCards.Add(playedCard);
        }

        /// <summary>
        /// 
        /// </summary>
        private static void ClearPlayedCards()
        {
            playedCards.Clear();
        }


        /*Pending*/
        public static void DecideWinner()
        {

        }

        public static List<Column> ShowColumns()
        {
            List<Column> columns = new List<Column>
            {
                column1,
                column2,
                column3,
                column4
            };

            return columns;
        }

        public static List<Card> GetCards()
        {
            return cards;
        }
    }
}
