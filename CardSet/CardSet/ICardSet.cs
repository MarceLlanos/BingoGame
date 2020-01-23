using System.Collections.Generic;

namespace BingoGame
{
    public interface ICardSet
    {
        void DrawDeckOfCards(int quantityOfCards, ICardPrototypeFactory cardPrototype);
        void ShowCards();
        void ShowCrosoutCards();
        List<ICard> GetCards();
        void CrossoutCards(List<IBall> ballsExtracted);
    }
}