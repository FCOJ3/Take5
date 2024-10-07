using System.Collections.Generic;

namespace TakeFive_AI
{
    internal interface IPlayer
    {
        void PlayCard(Card card);

        void AddNegativePoints(List<Card> cardsReceived);

        List<Card> ShowHand();

        int GetPoints();

        void ReceiveCards(List<Card> cardsReceived);
    }
}
