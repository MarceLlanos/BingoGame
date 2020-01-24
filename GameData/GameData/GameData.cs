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
        int wayToWin;

        public GameData(int quantityOfBalls, int quantityOfCards, int wayToWin)
        {
            this.wayToWin = wayToWin;
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

        public int GetWayToWin()
        {
            return wayToWin;
        }

        public void SetQuantityOfBalls(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
        }

        public void SetQuantityOfCards(int quantityOfCards)
        {
            this.quantityOfCards = quantityOfCards;
        }

        public void SetWayToWin(int wayToWin)
        {
            this.wayToWin = wayToWin;
        }
    }
}
