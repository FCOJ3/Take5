namespace TakeFive_AI
{
    public class Card
    {
        public int number { get; set; } = 0;
        public int bullsNumber { get; set; } = 0;

        public Card(int number, int bullsNumber)
        {
            this.number = number;
            this.bullsNumber = bullsNumber;
        }
    }
}
