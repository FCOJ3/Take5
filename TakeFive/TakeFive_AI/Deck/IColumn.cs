using System.Collections.Generic;

namespace TakeFive_AI
{
    internal interface IColumn
    {
        void AddCardToColumn(Card card);

        void CheckForCardsInColumn();

        void RemoveCards();

        Card GetLastCard();
    }

    public class Column : IColumn
    {
        public List<Card> cardsInColumn =  new List<Card>();

        public Column(Card initialCard)
        {
            cardsInColumn.Add(initialCard);
        }

        public void AddCardToColumn(Card card)
        {

        }

        public void CheckForCardsInColumn()
        {

        }

        public void RemoveCards()
        {
            cardsInColumn.Clear();
        }

        public Card GetLastCard()
        {
            return null;
        }
    }
}
