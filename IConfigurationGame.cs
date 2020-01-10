using System;
namespace BingoGame
{
    public interface IConfigurationGame
    {
        IDataCard GetDataCard();
        int GetQuantityCards();
        void SetQuantityCards(int quantityCards);
    }
}
