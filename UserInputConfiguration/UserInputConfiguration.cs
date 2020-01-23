using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class UserInputConfiguration : IUserInputConfiguration
    {
        int optionGame;
        int quantityOfCards;
        int optionToWin;

        public int GetOptionGame()
        {
            return optionGame;
        }

        public int GetOptionToWin()
        {
            return optionToWin;
        }

        public int GetQuantityOfCards()
        {
            return quantityOfCards;
        }

        public void SetOptionGame(int optionGame)
        {
            this.optionGame = optionGame;
        }

        public void SetOptionToWin(int optionToWin)
        {
            this.optionToWin = optionToWin;
        }

        public void SetQuantityOfCards(int quantityOfCards)
        {
            this.quantityOfCards = quantityOfCards;
        }
    }
}
