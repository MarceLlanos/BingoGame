using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceLocator();
            var commandGame = new CommandGame();
            new GameMenuCommand().GameInitCommand(service);

            commandGame.GetCommand(service);

            Console.ReadKey();
        }
    }
}
