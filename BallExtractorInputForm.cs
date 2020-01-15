using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallExtractorInputForm : IInputForm
    {
        public string OptionInput()
        {
            Console.WriteLine("");
            Console.WriteLine("How many bingo balls do you want?");

            return Console.ReadLine();
        }
    }
}
