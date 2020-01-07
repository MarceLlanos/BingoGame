using System.Collections.Generic;

namespace BingoGame
{
    public interface IGeneratorCards
    {
        List<ICard> GenerateCards(int quantityOfCards, ICard card);
    }
}