using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardInputForm : IInputForm
    {

        public string OptionInput()
        {
            Console.WriteLine("");
            Console.WriteLine("How many cards do you want?");
            return Console.ReadLine();
        }
    }
}
