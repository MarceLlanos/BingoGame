using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IUserInputConfiguration
    {
        int GetOptionGame();
        int GetQuantityOfCards();
        int GetOptionToWin();
        void SetOptionGame(int optionGame);
        void SetQuantityOfCards(int quantityOfCards);
        void SetOptionToWin(int optionToWin);
    }
}
