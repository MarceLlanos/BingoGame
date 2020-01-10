using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameData : IGameData
    {
        int quantityOfBalls;
        int quantityOfCards;

        public GameData(int quantityOfBalls, int quantityOfCards)
        {
            this.quantityOfBalls = quantityOfBalls;
            this.quantityOfCards = quantityOfCards;
        }

        public int GetQuantityOfBalls()
        {
            return quantityOfBalls;
        }

        public int GetQuantityOfCards()
        {
            return quantityOfCards;
        }

        public void SetQuantityOfBalls(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
        }

        public void SetQuantityOfCards(int quantityOfCards)
        {
            this.quantityOfCards = quantityOfCards;
        }
    }
}
