using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameInputForm : IInputForm
    {
        public string OptionInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose the type of the game");
            Console.WriteLine("1 = 75 ball bingo Game.");
            Console.WriteLine("2 = 90 ball bingo Game or Housie/Bingo Game");
            return Console.ReadLine();
        }
    }
}
