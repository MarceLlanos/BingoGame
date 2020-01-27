using System.Collections.Generic;

namespace BingoGame
{
    public interface ICardSet
    {
        void DrawDeckOfCards(int quantityOfCards, ICardPrototypeFactory cardPrototype);
        void ShowCards();
        List<ICard> GetCards();
        void CrossoutCards(List<IBall> ballsExtracted);
        void PrintCards(List<ICard> cardSet);
    }
}