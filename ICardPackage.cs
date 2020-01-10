using System.Collections.Generic;

namespace BingoGame
{
    public interface ICardPackage
    {
        List<ICard> DeckOfCards(IGameDataSetting gameDataSetting);
        void ShowCards();
    }
}