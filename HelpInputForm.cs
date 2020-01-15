using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HelpInputForm : IInputForm
    {
        public string OptionInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Bingo Game:");
            Console.WriteLine("PLAY = Start the game");
            Console.WriteLine("HELP = Show the commands for play");
            Console.WriteLine("CANCEL = Finish the game");
            return Console.ReadLine();
        }
    }
}
