using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ExitAction : IAction
    {
        public void ShowAction()
        {
            System.Environment.Exit(-1);
            Console.WriteLine("Come Back Soon!");
        }
    }
}
