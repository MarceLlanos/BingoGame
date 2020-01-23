using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HelpAction : IAction
    {
        public void ShowAction()
        {
            Console.WriteLine("");
            Console.WriteLine("SHOW CARDS = Show the cards. ");
            Console.WriteLine("SHOW CARDS CROSSOUT = Show the cards crossout. ");
            Console.WriteLine("WINNER = Shows the winner card. ");
            Console.WriteLine("SHOW BALLS = Shows all the bingo balls. ");
            Console.WriteLine("SHOW TAKE OFF BALLS = Shows extracteds balls. ");
            Console.WriteLine("SHOW ALL EXTRACTED BALLS = Shows all the balls extracted. ");
            Console.WriteLine("TAKE OFF BALLS = Generate bingo balls");
        }
    }
}
