using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameDataFactory : IGameDataFactory
    {
        public IGameData CreateGameData(int optionNumber, int quantityOfCards, int wayToWin)
        {
            switch (optionNumber)
            {
                case 1: return new GameData(75, quantityOfCards, wayToWin);
                case 2: return new GameData(90, quantityOfCards, wayToWin);
            }

            return new GameData(75, quantityOfCards, wayToWin);
        }
    }
}
