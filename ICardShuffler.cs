using System.Collections.Generic;

namespace BingoGame
{
    public interface ICardShuffler
    {
        List<ICard> DeckOfCards(int quantityOfCards, ICard card);
        void ShowDeckOfCards();
    }
}