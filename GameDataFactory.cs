using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameDataFactory : IGameDataFactory
    {
        public IGameData CreateGameData(int optionNumber, int quantityOfBalls)
        {
            switch (optionNumber)
            {
                case 1: return new GameData(75, quantityOfBalls);
                case 2: return new GameData(90, quantityOfBalls);
            }

            return new GameData(75, quantityOfBalls);
        }
    }
}
