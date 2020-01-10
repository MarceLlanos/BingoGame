using System;
namespace BingoGame
{
    public class ConfigurationGame:IConfigurationGame
    {
        IDataCard dataCard;
        int quantityCards;

        public ConfigurationGame(IDataCard dataCard, int quantityCards)
        {
            this.dataCard = dataCard;
            this.quantityCards = quantityCards;
        }

        public IDataCard GetDataCard()
        {
            return dataCard;
        }

        public int GetQuantityCards()
        {
            return quantityCards;
        }

        public void SetQuantityCards(int quantityCards)
        {
            this.quantityCards = quantityCards;
        }
    }
}
