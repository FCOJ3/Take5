using System.Collections.Generic;

namespace TakeFive_AI
{
    public class Player : IPlayer
    {
        List<Card> cardsLost;
        public List<Card> hand;
        int points;

        public Player()
        {
            cardsLost = new List<Card>();
            hand = new List<Card>();
            points = 0;
        }

        public void PlayCard(Card card)
        {
            Engine.ReceiveCard(card);
        }

        public void AddNegativePoints(List<Card> cardsReceived)
        {
            foreach (Card item in cardsReceived)
            {
                points += item.bullsNumber;
            }
        }

        public List<Card> ShowHand()
        {
            return hand;
        }

        public int GetPoints()
        {
            return points;
        }

        public void ReceiveCards(List<Card> cardsReceived)
        {
            foreach (Card item in cardsReceived)
            {
                cardsLost.Add(item);
            }

            AddNegativePoints(cardsReceived);
        }
    }
}
