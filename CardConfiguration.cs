namespace BingoGame
{
    public class CardConfiguration:ICardConfiguration
    {
        private IDataCard dataCard;
        private int quantityCards;

        public CardConfiguration(IDataCard dataCard, int quantityCards)
        {
            this.dataCard = dataCard;
            this.quantityCards = quantityCards;
        }
    }
}