using System.Collections.Generic;

namespace BingoGame
{
    public interface ICardSet
    {
        List<ICard> DrawDeckOfCards(int quantityOfCards, ICardPrototypeFactory cardPrototype);
        void ShowCards();
    }
}