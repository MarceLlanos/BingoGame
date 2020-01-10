using System.Collections.Generic;

namespace BingoGame
{
    public interface ICardPackage
    {
        List<ICard> DrawDeckOfCards();
        void ShowCards();
    }
}