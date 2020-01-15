using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HelpCommand : IInputForm
    {
        public string OptionInput()
        {
            Console.WriteLine("");
            Console.WriteLine(" SHOW = Show the cards. ");
            Console.WriteLine(" WINNER = shows the winner card. ");
            Console.WriteLine(" BINGO BALLS = shows all the bingo balls. ");
            Console.WriteLine(" SHOW BALLS = shows the balls generated. ");
            Console.WriteLine(" TAKE OFF BALLS = generate bingo balls");
            return Console.ReadLine();

        }
    }
}
